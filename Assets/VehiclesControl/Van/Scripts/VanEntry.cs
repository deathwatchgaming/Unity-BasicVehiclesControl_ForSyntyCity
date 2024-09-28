/*
 * File: Van Entry
 * Name: VanEntry.cs
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

    // public class VanEntry 
    public class VanEntry : MonoBehaviour
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

            [Tooltip("The van game object")]
            // GameObject _van
            [SerializeField] private GameObject _van;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inVan is false
            [SerializeField] private bool _inVan = false;
        
        // VanController _vanScript
        private VanController _vanScript;

        // Camera _vanCamera
        private Camera _vanCamera;

        // AudioListener _vanCameraAudioListener
        private AudioListener _vanCameraAudioListener; 

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
            // _vanScript is GetComponent VanController
            _vanScript = GetComponent<VanController>();

            // _vanScript enabled is false
            _vanScript.enabled = false;
            
            // _vanScript is GetComponentInChildren Camera
            _vanCamera = GetComponentInChildren<Camera>();

            // _vanCamera enabled is false
            _vanCamera.enabled = false;
           
            // _vanCameraAudioListener is GetComponentInChildren AudioListener
            _vanCameraAudioListener = GetComponentInChildren<AudioListener>();

            // _vanCameraAudioListener enabled is false
            _vanCameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName Van_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("Van_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inVan and Input GetKey KeyCode _exitKey
            if (_inVan && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _vanScript enabled is false
                _vanScript.enabled = false;

                // _vanCamera enabled is false
                _vanCamera.enabled = false;

                // _vanCameraAudioListener enabled is false
                _vanCameraAudioListener.enabled = false; 

                // _inVan is false
                _inVan = false;

            } // close if _inVan and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inVan and gameObject tag is Player
            if (!_inVan && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inVan and gameObject tag is Player
            
            // if not _inVan and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inVan && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _van transform
                _player.transform.parent = _van.transform;

                // _vanScript enabled is true
                _vanScript.enabled = true;

                // _vanCamera enabled is true
                _vanCamera.enabled = true;

                // _vanCameraAudioListener enabled is true
                _vanCameraAudioListener.enabled = true; 

                // _inVan is true
                _inVan = true;

            } // close if not _inVan and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class VanEntry  

} // close namespace VehiclesControl
