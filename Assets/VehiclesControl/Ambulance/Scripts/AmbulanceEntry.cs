/*
 * File: Ambulance Entry 
 * Name: AmbulanceEntry.cs
 * Author: DeathwatchGaming
 * License: MIT
 */

// using
using UnityEngine;
using System.Collections;

// namespace VehiclesControl
namespace VehiclesControl
{
    // RequireComponent typeof BoxCollider
    [RequireComponent(typeof(BoxCollider))]

    // public class AmbulanceEntry 
    public class AmbulanceEntry : MonoBehaviour
    {  
        // Input Customizations
        [Header("Input Customizations")] 

            [Tooltip("The vehicle entry key code")]
            // KeyCode _enterKey
            [SerializeField] private KeyCode _enterKey = KeyCode.E;

            [Tooltip("The vehicle exit key code")]
            // KeyCode _exitKey
            [SerializeField] private KeyCode _exitKey = KeyCode.F;

        // Game Objects
        [Header("Game Objects")]

            [Tooltip("The armored truck game object")]
            // GameObject _ambulance
            [SerializeField] private GameObject _ambulance;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inAmbulance is false
            [SerializeField] private bool _inAmbulance = false;
        
        // AmbulanceController _ambulanceScript
        private AmbulanceController _ambulanceScript;
        
        // Camera _ambulanceCamera
        private Camera _ambulanceCamera;

        // AudioListener _ambulanceCameraAudioListener
        private AudioListener _ambulanceCameraAudioListener; 

        // Rigidbody _rigidbody
        private Rigidbody _rigidbody;

        // GameObject FindInActiveObjectByName
        GameObject FindInActiveObjectByName(string name)
        {
            // Transform[] objs
            Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];

            // for
            for (int i = 0; i < objs.Length; i++)
            {
                // if
                if (objs[i].hideFlags == HideFlags.None)
                {
                    // if
                    if (objs[i].name == name)
                    {
                        // return
                        return objs[i].gameObject;

                    } // close if

                } // close if

            } // close for

            // return
            return null;

        } // close GameObject FindInActiveObjectByName
        
        // private void Start
        private void Start() 
        {
            // _ambulanceScript is GetComponent AmbulanceController
            _ambulanceScript = GetComponent<AmbulanceController>();

            // _ambulanceScript enabled is false
            _ambulanceScript.enabled = false;
            
            // _ambulanceCamera is GetComponentInChildren Camera
            _ambulanceCamera = GetComponentInChildren<Camera>();
            
            // _ambulanceCamera enabled is false
            _ambulanceCamera.enabled = false;

            // _ambulanceCameraAudioListener is GetComponentInChildren AudioListener
            _ambulanceCameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _ambulanceCameraAudioListener enabled is false
            _ambulanceCameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName Ambulance_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("Ambulance_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

    	} // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inAmbulance and Input GetKey KeyCode _exitKey
            if (_inAmbulance && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _ambulanceScript enabled is false
                _ambulanceScript.enabled = false;
                
                // _ambulanceCamera enabled is false
                _ambulanceCamera.enabled = false;

                // _ambulanceCameraAudioListener enabled is false
                _ambulanceCameraAudioListener.enabled = false;                 

                // _inAmbulance is false
                _inAmbulance = false;

            } // close if _inAmbulance and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
        	// if not _inAmbulance and gameObject tag is Player
            if (!_inAmbulance && other.gameObject.tag == "Player")
            {
            	// _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inAmbulance and gameObject tag is Player
            
            // if not _inAmbulance and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inAmbulance && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _ambulance transform
                _player.transform.parent = _ambulance.transform;

                // _ambulanceScript enabled is true
                _ambulanceScript.enabled = true;
                
                // _ambulanceCamera enabled is true
                _ambulanceCamera.enabled = true;

                // _ambulanceCameraAudioListener enabled is true
                _ambulanceCameraAudioListener.enabled = true; 

                // _inAmbulance is true
                _inAmbulance = true;

            } // close if not _inAmbulance and gameObject tag is Player and Input GetKey KeyCode _enterKey

        } // close private void OnTriggerStay Collider other
        
        // private void OnTriggerExit Collider other
        private void OnTriggerExit(Collider other)
        {
            // if gameObject tag is Player
            if (other.gameObject.tag == "Player")
            {
            	// _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);
                
                // StartCoroutine RigidbodySleep
                StartCoroutine(RigidbodySleep(0.000001f)); 

            } // close if gameObject tag is Player

        } // close private void OnTriggerExit Collider other

        // private IEnumerator RigidbodySleep float duration
        private IEnumerator RigidbodySleep(float duration) 
        {
            // WaitForSeconds duration
            yield return new WaitForSeconds(duration);
            
            // _rigidbody Sleep
            _rigidbody.Sleep();

        } // close private IEnumerator RigidbodySleep float duration  
        
    } // close public class AmbulanceEntry  

} // close namespace VehiclesControl
