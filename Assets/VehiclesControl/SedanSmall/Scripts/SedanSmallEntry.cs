/*
 * File: SedanSmall Entry
 * Name: SedanSmallEntry.cs
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

    // public class SedanSmallEntry 
    public class SedanSmallEntry : MonoBehaviour
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

            [Tooltip("The sedanSmall game object")]
            // GameObject _sedanSmall
            [SerializeField] private GameObject _sedanSmall;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inSedanSmall is false
            [SerializeField] private bool _inSedanSmall = false;
        
        // SedanSmallController _sedanSmallScript
        private SedanSmallController _sedanSmallScript;

        // Camera _sedanSmallCamera
        private Camera _sedanSmallCamera;

        // AudioListener _sedanSmallCameraAudioListener
        private AudioListener _sedanSmallCameraAudioListener; 

        // Rigidbody _rigidbody
        private Rigidbody _rigidbody;        

        // private void Start
        private void Start() 
        {
            // _sedanSmallScript is GetComponent SedanSmallController
            _sedanSmallScript = GetComponent<SedanSmallController>();

            // _sedanSmallScript enabled is false
            _sedanSmallScript.enabled = false;
            
            // _sedanSmallScript is GetComponentInChildren
            _sedanSmallCamera = GetComponentInChildren<Camera>();

            // _sedanSmallCamera enabled is false
            _sedanSmallCamera.enabled = false;

            // _sedanSmallCameraAudioListener is GetComponentInChildren AudioListener
            _sedanSmallCameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _sedanSmallCameraAudioListener enabled is false
            _sedanSmallCameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // _interfaceTextObject is GameObject Find SedanSmall_EntryKey
            _interfaceTextObject = GameObject.Find("SedanSmall_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inSedanSmall and Input GetKey KeyCode _exitKey
            if (_inSedanSmall && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _sedanSmallScript enabled is false
                _sedanSmallScript.enabled = false;
                
                // _sedanSmallCamera enabled is false
                _sedanSmallCamera.enabled = false;

                // _sedanSmallCameraAudioListener enabled is false
                _sedanSmallCameraAudioListener.enabled = false; 

                // _inSedanSmall is false
                _inSedanSmall = false;

            } // close if _inSedanSmall and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inSedanSmall and gameObject tag is Player
            if (!_inSedanSmall && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inSedanSmall and gameObject tag is Player
            
            // if not _inSedanSmall and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inSedanSmall && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _sedanSmall transform
                _player.transform.parent = _sedanSmall.transform;

                // _sedanSmallScript enabled is true
                _sedanSmallScript.enabled = true;
                
                // _sedanSmallCamera enabled is true
                _sedanSmallCamera.enabled = true;

                // _sedanSmallCameraAudioListener enabled is true
                _sedanSmallCameraAudioListener.enabled = true; 

                // _inSedanSmall is true
                _inSedanSmall = true;

            } // close if not _inSedanSmall and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class SedanSmallEntry  

} // close namespace VehiclesControl
