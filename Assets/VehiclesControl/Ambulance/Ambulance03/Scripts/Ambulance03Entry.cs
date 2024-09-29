/*
 * File: Ambulance 03 Entry 
 * Name: Ambulance03Entry.cs
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

    // public class Ambulance03Entry 
    public class Ambulance03Entry : MonoBehaviour
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

            [Tooltip("The ambulance game object")]
            // GameObject _ambulance03
            [SerializeField] private GameObject _ambulance03;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inAmbulance03 is false
            [SerializeField] private bool _inAmbulance03 = false;
        
        // Ambulance03Controller _ambulance03Script
        private Ambulance03Controller _ambulance03Script;
        
        // Camera _ambulance03Camera
        private Camera _ambulance03Camera;

        // AudioListener _ambulance03CameraAudioListener
        private AudioListener _ambulance03CameraAudioListener; 

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
            // _ambulance03Script is GetComponent Ambulance03Controller
            _ambulance03Script = GetComponent<Ambulance03Controller>();

            // _ambulance03Script enabled is false
            _ambulance03Script.enabled = false;
            
            // _ambulance03Camera is GetComponentInChildren Camera
            _ambulance03Camera = GetComponentInChildren<Camera>();
            
            // _ambulance03Camera enabled is false
            _ambulance03Camera.enabled = false;

            // _ambulance03CameraAudioListener is GetComponentInChildren AudioListener
            _ambulance03CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _ambulance03CameraAudioListener enabled is false
            _ambulance03CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName Ambulance03_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("Ambulance03_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

    	} // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inAmbulance03 and Input GetKey KeyCode _exitKey
            if (_inAmbulance03 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _ambulance03Script enabled is false
                _ambulance03Script.enabled = false;
                
                // _ambulance03Camera enabled is false
                _ambulance03Camera.enabled = false;

                // _ambulance03CameraAudioListener enabled is false
                _ambulance03CameraAudioListener.enabled = false;                 

                // _inAmbulance03 is false
                _inAmbulance03 = false;

            } // close if _inAmbulance03 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
        	// if not _inAmbulance03 and gameObject tag is Player
            if (!_inAmbulance03 && other.gameObject.tag == "Player")
            {
            	// _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inAmbulance03 and gameObject tag is Player
            
            // if not _inAmbulance03 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inAmbulance03 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _ambulance03 transform
                _player.transform.parent = _ambulance03.transform;

                // _ambulance03Script enabled is true
                _ambulance03Script.enabled = true;
                
                // _ambulance03Camera enabled is true
                _ambulance03Camera.enabled = true;

                // _ambulance03CameraAudioListener enabled is true
                _ambulance03CameraAudioListener.enabled = true; 

                // _inAmbulance03 is true
                _inAmbulance03 = true;

            } // close if not _inAmbulance03 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class Ambulance03Entry  

} // close namespace VehiclesControl
