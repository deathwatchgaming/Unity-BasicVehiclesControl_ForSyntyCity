/*
 * File: Dune Buggy Entry
 * Name: PoliceCruiserEntry.cs
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

    // public class PoliceCruiserEntry 
    public class PoliceCruiserEntry : MonoBehaviour
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

            [Tooltip("The police cruiser game object")]
            // GameObject _policeCruiser
            [SerializeField] private GameObject _policeCruiser;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inPoliceCruiser is false
            [SerializeField] private bool _inPoliceCruiser = false;
        
        // PoliceCruiserController _policeCruiserScript
        private PoliceCruiserController _policeCruiserScript;
        
        // Camera _policeCruiserCamera
        private Camera _policeCruiserCamera;

        // AudioListener _policeCruiserCameraAudioListener
        private AudioListener _policeCruiserCameraAudioListener; 

        // Rigidbody _rigidbody
        private Rigidbody _rigidbody;
        
        // private void Start
        private void Start() 
        {
            // _policeCruiserScript is GetComponent PoliceCruiserController
            _policeCruiserScript = GetComponent<PoliceCruiserController>();

            // _policeCruiserScript enabled is false
            _policeCruiserScript.enabled = false;
            
            // _policeCruiserCamera is GetComponentInChildren Camera
            _policeCruiserCamera = GetComponentInChildren<Camera>();
            
            // _policeCruiserCamera enabled is false
            _policeCruiserCamera.enabled = false;
           
            // _policeCruiserCameraAudioListener is GetComponentInChildren AudioListener
            _policeCruiserCameraAudioListener = GetComponentInChildren<AudioListener>();

            // _policeCruiserCameraAudioListener enabled is false
            _policeCruiserCameraAudioListener.enabled = false;

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // _interfaceTextObject is GameObject Find PoliceCruiser_EntryKey
            _interfaceTextObject = GameObject.Find("PoliceCruiser_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inPoliceCruiser and Input GetKey KeyCode _exitKey
            if (_inPoliceCruiser && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _policeCruiserScript enabled is false
                _policeCruiserScript.enabled = false;
                
                // _policeCruiserCamera enabled is false
                _policeCruiserCamera.enabled = false;

                // _policeCruiserCameraAudioListener enabled is false
                _policeCruiserCameraAudioListener.enabled = false;

                // _inPoliceCruiser is false
                _inPoliceCruiser = false;

            } // close if _inPoliceCruiser and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inPoliceCruiser and gameObject tag is Player
            if (!_inPoliceCruiser && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inPoliceCruiser and gameObject tag is Player
            
            // if not _inPoliceCruiser and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inPoliceCruiser && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _policeCruiser transform
                _player.transform.parent = _policeCruiser.transform;

                // _policeCruiserScript enabled is true
                _policeCruiserScript.enabled = true;
                
                // _policeCruiserCamera enabled is true
                _policeCruiserCamera.enabled = true;

                // _policeCruiserCameraAudioListener enabled is true
                _policeCruiserCameraAudioListener.enabled = true;

                // _inPoliceCruiser is true
                _inPoliceCruiser = true;

            } // close if not _inPoliceCruiser and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class PoliceCruiserEntry  

} // close namespace VehiclesControl
