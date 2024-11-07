/*
 * File: SedanLarge 04 Entry
 * Name: SedanLarge04Entry.cs
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

    // public class SedanLarge04Entry 
    public class SedanLarge04Entry : MonoBehaviour
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

            [Tooltip("The sedanLarge04 game object")]
            // GameObject _sedanLarge04
            [SerializeField] private GameObject _sedanLarge04;

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
            // bool _inSedanLarge04 is false
            [SerializeField] private bool _inSedanLarge04 = false;
        
        // SedanLarge04Controller _sedanLarge04Script
        private SedanLarge04Controller _sedanLarge04Script;

        // Camera _sedanLarge04Camera
        private Camera _sedanLarge04Camera;

        // AudioListener _sedanLarge04CameraAudioListener
        private AudioListener _sedanLarge04CameraAudioListener; 

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
            
            [Tooltip("The sedan large 04 compass")]
            // SedanLarge04Compass _sedanLG04Compass
            [SerializeField] private SedanLarge04Compass _sedanLG04Compass;  

        //public static SedanLarge04Entry _sedanLarge04Entry;
         
        // private void Start
        private void Start() 
        {
            //_sedanLarge04Entry = this;
            
            // _sedanLarge04Script is GetComponent SedanLarge04Controller
            _sedanLarge04Script = GetComponent<SedanLarge04Controller>();

            // _sedanLarge04Script enabled is false
            _sedanLarge04Script.enabled = false;
            
            // _sedanLarge04Script is GetComponentInChildren
            _sedanLarge04Camera = GetComponentInChildren<Camera>();

            // _sedanLarge04Camera enabled is false
            _sedanLarge04Camera.enabled = false;

            // _sedanLarge04CameraAudioListener is GetComponentInChildren AudioListener
            _sedanLarge04CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _sedanLarge04CameraAudioListener enabled is false
            _sedanLarge04CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName SedanLarge04_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("SedanLarge04_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _sedanLG04Compass enabled is false
            _sedanLG04Compass.enabled = false;

            // _sedanLG04Compass compassEnabled is false
            _sedanLG04Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The SedanLarge04 compass is disabled");

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inSedanLarge04 and Input GetKey KeyCode _exitKey
            if (_inSedanLarge04 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _sedanLarge04Script enabled is false
                _sedanLarge04Script.enabled = false;
                
                // _sedanLarge04Camera enabled is false
                _sedanLarge04Camera.enabled = false;

                // _sedanLarge04CameraAudioListener enabled is false
                _sedanLarge04CameraAudioListener.enabled = false; 

                // _inSedanLarge04 is false
                _inSedanLarge04 = false;

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true 
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled");

                // _sedanLG04Compass enabled is false
                _sedanLG04Compass.enabled = false;

                // _sedanLG04Compass compassEnabled is false
                _sedanLG04Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The SedanLarge04 compass is disabled");         

            } // close if _inSedanLarge04 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inSedanLarge04 and gameObject tag is Player
            if (!_inSedanLarge04 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inSedanLarge04 and gameObject tag is Player
            
            // if not _inSedanLarge04 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inSedanLarge04 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _sedanLarge04 transform
                _player.transform.parent = _sedanLarge04.transform;

                // _sedanLarge04Script enabled is true
                _sedanLarge04Script.enabled = true;
                
                // _sedanLarge04Camera enabled is true
                _sedanLarge04Camera.enabled = true;

                // _sedanLarge04CameraAudioListener enabled is true
                _sedanLarge04CameraAudioListener.enabled = true; 

                // _inSedanLarge04 is true
                _inSedanLarge04 = true;

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled"); 

                // _sedanLG04Compass enabled is true
                _sedanLG04Compass.enabled = true;

                // _sedanLG04Compass compassEnabled is true
                _sedanLG04Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The SedanLarge04 compass is enabled");                

            } // close if not _inSedanLarge04 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class SedanLarge04Entry  

} // close namespace VehiclesControl
