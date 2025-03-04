/*
 * File: Taxi 04 Entry
 * Name: Taxi04Entry.cs
 * Author: DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 6+
 */

// using
using UnityEngine;
using System.Collections;
using NavigationControl;

// namespace VehiclesControl
namespace VehiclesControl
{
    // RequireComponent typeof BoxCollider
    [RequireComponent(typeof(BoxCollider))]

    // public class Taxi04Entry 
    public class Taxi04Entry : MonoBehaviour
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

            [Tooltip("The taxi04 game object")]
            // GameObject _taxi04
            [SerializeField] private GameObject _taxi04;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;

        // Rigidbody Sleep
        [Header("Rigidbody Sleep")]

            [Tooltip("The rigidbody sleep wait for seconds duration")]
            // float duration is 0.0001
            [SerializeField] private float duration = 0.0001f; 
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inTaxi04 is false
            [SerializeField] private bool _inTaxi04 = false;
        
        // Taxi04Controller _taxi04Script
        private Taxi04Controller _taxi04Script;

        // Camera _taxi04Camera
        private Camera _taxi04Camera;

        // AudioListener _taxi04CameraAudioListener
        private AudioListener _taxi04CameraAudioListener; 

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

        // Compass
        [Header("Compass")]

            [Tooltip("The player compass")]
            // PlayerCompass _playerCompass
            [SerializeField] private PlayerCompass _playerCompass;
            
            [Tooltip("The taxi 04 compass")]
            // Taxi04Compass _taxi04Compass
            [SerializeField] private Taxi04Compass _taxi04Compass;  

        //public static Taxi04Entry _taxi04Entry;
        
        // private void Start
        private void Start() 
        {
            //_taxi04Entry = this;

            // _taxi04Script is GetComponent Taxi04Controller
            _taxi04Script = GetComponent<Taxi04Controller>();

            // _taxi04Script enabled is false
            _taxi04Script.enabled = false;
            
            // _taxi04Script is GetComponentInChildren
            _taxi04Camera = GetComponentInChildren<Camera>();

            // _taxi04Camera enabled is false
            _taxi04Camera.enabled = false;

            // _taxi04CameraAudioListener is GetComponentInChildren AudioListener
            _taxi04CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _taxi04CameraAudioListener enabled is false
            _taxi04CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName Taxi04_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("Taxi04_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _taxi04Compass enabled is false
            _taxi04Compass.enabled = false;

            // _taxi04Compass compassEnabled is false
            _taxi04Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The Taxi04 compass is disabled");

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inTaxi04 and Input GetKey KeyCode _exitKey
            if (_inTaxi04 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _taxi04Script enabled is false
                _taxi04Script.enabled = false;
                
                // _taxi04Camera enabled is false
                _taxi04Camera.enabled = false;

                // _taxi04CameraAudioListener enabled is false
                _taxi04CameraAudioListener.enabled = false; 

                // _inTaxi04 is false
                _inTaxi04 = false;

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true 
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled");

                // _taxi04Compass enabled is false
                _taxi04Compass.enabled = false;

                // _taxi04Compass compassEnabled is false
                _taxi04Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Taxi04 compass is disabled");         

            } // close if _inTaxi04 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inTaxi04 and gameObject tag is Player
            if (!_inTaxi04 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inTaxi04 and gameObject tag is Player
            
            // if not _inTaxi04 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inTaxi04 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _taxi04 transform
                _player.transform.parent = _taxi04.transform;

                // _taxi04Script enabled is true
                _taxi04Script.enabled = true;
                
                // _taxi04Camera enabled is true
                _taxi04Camera.enabled = true;

                // _taxi04CameraAudioListener enabled is true
                _taxi04CameraAudioListener.enabled = true; 

                // _inTaxi04 is true
                _inTaxi04 = true;

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled"); 

                // _taxi04Compass enabled is true
                _taxi04Compass.enabled = true;

                // _taxi04Compass compassEnabled is true
                _taxi04Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Taxi04 compass is enabled");                

            } // close if not _inTaxi04 and gameObject tag is Player and Input GetKey KeyCode _enterKey

        } // close private void OnTriggerStay Collider other
        
        // private void OnTriggerExit Collider other
        private void OnTriggerExit(Collider other)
        {
            // if gameObject tag is Player
            if (other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);
                
                // StartCoroutine RigidbodySleep duration
                StartCoroutine(RigidbodySleep(duration)); 

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
        
    } // close public class Taxi04Entry  

} // close namespace VehiclesControl
