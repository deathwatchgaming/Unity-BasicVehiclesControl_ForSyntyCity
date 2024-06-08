/*
 * File: Taxi Entry
 * Name: TaxiEntry.cs
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

    // public class TaxiEntry 
    public class TaxiEntry : MonoBehaviour
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

            [Tooltip("The taxi game object")]
            // GameObject _taxi
            [SerializeField] private GameObject _taxi;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inTaxi is false
            [SerializeField] private bool _inTaxi = false;
        
        // TaxiController _taxiScript
        private TaxiController _taxiScript;

        // Camera _taxiCamera
        private Camera _taxiCamera;

        // AudioListener _taxiCameraAudioListener
        private AudioListener _taxiCameraAudioListener; 

        // Rigidbody _rigidbody
        private Rigidbody _rigidbody;        

        // private void Start
        private void Start() 
        {
            // _taxiScript is GetComponent TaxiController
            _taxiScript = GetComponent<TaxiController>();

            // _taxiScript enabled is false
            _taxiScript.enabled = false;
            
            // _taxiScript is GetComponentInChildren
            _taxiCamera = GetComponentInChildren<Camera>();

            // _taxiCamera enabled is false
            _taxiCamera.enabled = false;

            // _taxiCameraAudioListener is GetComponentInChildren AudioListener
            _taxiCameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _taxiCameraAudioListener enabled is false
            _taxiCameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // _interfaceTextObject is GameObject Find Taxi_EntryKey
            _interfaceTextObject = GameObject.Find("Taxi_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inTaxi and Input GetKey KeyCode _exitKey
            if (_inTaxi && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _taxiScript enabled is false
                _taxiScript.enabled = false;
                
                // _taxiCamera enabled is false
                _taxiCamera.enabled = false;

                // _taxiCameraAudioListener enabled is false
                _taxiCameraAudioListener.enabled = false; 

                // _inTaxi is false
                _inTaxi = false;

            } // close if _inTaxi and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inTaxi and gameObject tag is Player
            if (!_inTaxi && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inTaxi and gameObject tag is Player
            
            // if not _inTaxi and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inTaxi && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _taxi transform
                _player.transform.parent = _taxi.transform;

                // _taxiScript enabled is true
                _taxiScript.enabled = true;
                
                // _taxiCamera enabled is true
                _taxiCamera.enabled = true;

                // _taxiCameraAudioListener enabled is true
                _taxiCameraAudioListener.enabled = true; 

                // _inTaxi is true
                _inTaxi = true;

            } // close if not _inTaxi and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class TaxiEntry  

} // close namespace VehiclesControl
