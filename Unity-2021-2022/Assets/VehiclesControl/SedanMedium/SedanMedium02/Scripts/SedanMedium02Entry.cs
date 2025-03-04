/*
 * File: SedanMedium 02 Entry
 * Name: SedanMedium02Entry.cs
 * Author: DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 2021+ - 2022+
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

    // public class SedanMedium02Entry 
    public class SedanMedium02Entry : MonoBehaviour
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

            [Tooltip("The sedanMedium02 game object")]
            // GameObject _sedanMedium02
            [SerializeField] private GameObject _sedanMedium02;

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
            // bool _inSedanMedium02 is false
            [SerializeField] private bool _inSedanMedium02 = false;
        
        // SedanMedium02Controller _sedanMedium02Script
        private SedanMedium02Controller _sedanMedium02Script;

        // Camera _sedanMedium02Camera
        private Camera _sedanMedium02Camera;

        // AudioListener _sedanMedium02CameraAudioListener
        private AudioListener _sedanMedium02CameraAudioListener; 

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
            
            [Tooltip("The sedan medium 02 compass")]
            // SedanMedium02Compass _sedanMD02Compass
            [SerializeField] private SedanMedium02Compass _sedanMD02Compass;  

        //public static SedanMedium02Entry _sedanMedium02Entry;
         
        // private void Start
        private void Start() 
        {
            //_sedanMedium02Entry = this;
            
            // _sedanMedium02Script is GetComponent SedanMedium02Controller
            _sedanMedium02Script = GetComponent<SedanMedium02Controller>();

            // _sedanMedium02Script enabled is false
            _sedanMedium02Script.enabled = false;
            
            // _sedanMedium02Script is GetComponentInChildren
            _sedanMedium02Camera = GetComponentInChildren<Camera>();

            // _sedanMedium02Camera enabled is false
            _sedanMedium02Camera.enabled = false;

            // _sedanMedium02CameraAudioListener is GetComponentInChildren AudioListener
            _sedanMedium02CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _sedanMedium02CameraAudioListener enabled is false
            _sedanMedium02CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName SedanMedium02_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("SedanMedium02_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _sedanMD02Compass enabled is false
            _sedanMD02Compass.enabled = false;

            // _sedanMD02Compass compassEnabled is false
            _sedanMD02Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The SedanMedium02 compass is disabled");

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inSedanMedium02 and Input GetKey KeyCode _exitKey
            if (_inSedanMedium02 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _sedanMedium02Script enabled is false
                _sedanMedium02Script.enabled = false;
                
                // _sedanMedium02Camera enabled is false
                _sedanMedium02Camera.enabled = false;

                // _sedanMedium02CameraAudioListener enabled is false
                _sedanMedium02CameraAudioListener.enabled = false; 

                // _inSedanMedium02 is false
                _inSedanMedium02 = false;

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true 
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled");

                // _sedanMD02Compass enabled is false
                _sedanMD02Compass.enabled = false;

                // _sedanMD02Compass compassEnabled is false
                _sedanMD02Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The SedanMedium02 compass is disabled");         

            } // close if _inSedanMedium02 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inSedanMedium02 and gameObject tag is Player
            if (!_inSedanMedium02 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inSedanMedium02 and gameObject tag is Player
            
            // if not _inSedanMedium02 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inSedanMedium02 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _sedanMedium02 transform
                _player.transform.parent = _sedanMedium02.transform;

                // _sedanMedium02Script enabled is true
                _sedanMedium02Script.enabled = true;
                
                // _sedanMedium02Camera enabled is true
                _sedanMedium02Camera.enabled = true;

                // _sedanMedium02CameraAudioListener enabled is true
                _sedanMedium02CameraAudioListener.enabled = true; 

                // _inSedanMedium02 is true
                _inSedanMedium02 = true;

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled"); 

                // _sedanMD02Compass enabled is true
                _sedanMD02Compass.enabled = true;

                // _sedanMD02Compass compassEnabled is true
                _sedanMD02Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The SedanMedium02 compass is enabled");                

            } // close if not _inSedanMedium02 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class SedanMedium02Entry  

} // close namespace VehiclesControl
