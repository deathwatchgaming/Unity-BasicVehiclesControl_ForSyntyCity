/*
 * File: SedanSmall 02 Entry (New Input System)
 * Name: SedanSmall02Entry.cs
 * Author: DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 2021+ - 2022+
 */

// using
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using NavigationControl;

// namespace VehiclesControl
namespace VehiclesControl
{
    // RequireComponent typeof BoxCollider
    [RequireComponent(typeof(BoxCollider))]

    // public class SedanSmall02Entry 
    public class SedanSmall02Entry : MonoBehaviour
    {   
        // Game Objects
        [Header("Game Objects")]

            [Tooltip("The sedanSmall02 game object")]
            // GameObject _sedanSmall02
            [SerializeField] private GameObject _sedanSmall02;

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
            // bool _inSedanSmall02 is false
            [SerializeField] private bool _inSedanSmall02 = false;

        // Compass
        [Header("Compass")]

            [Tooltip("The player compass")]
            // PlayerCompass _playerCompass
            [SerializeField] private PlayerCompass _playerCompass;
            
            [Tooltip("The sedan small 02 compass")]
            // SedanSmall02Compass _sedanSM02Compass
            [SerializeField] private SedanSmall02Compass _sedanSM02Compass;  

        // Input Actions
        [Header("Input Actions")] 

            [Tooltip("The input action asset")]
            [SerializeField] private InputActionAsset _carControls;

        // InputAction _carEnterAction
        private InputAction _carEnterAction;

        // InputAction _carExitAction
        private InputAction _carExitAction;

        // bool _enterButton
        private bool _enterButton;

        // bool _exitButton
        private bool _exitButton;            
        
        // SedanSmall02Controller _sedanSmall02Script
        private SedanSmall02Controller _sedanSmall02Script;

        // Camera _sedanSmall02Camera
        private Camera _sedanSmall02Camera;

        // AudioListener _sedanSmall02CameraAudioListener
        private AudioListener _sedanSmall02CameraAudioListener; 

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

        //public static SedanSmall02Entry _sedanSmall02Entry;

        // private void Awake
        private void Awake()
        {
            // _carEnterAction
            _carEnterAction = _carControls.FindActionMap("Car").FindAction("Enter");

            // _carExitAction
            _carExitAction = _carControls.FindActionMap("Car").FindAction("Exit");

        } // close private void Awake

        // private void OnEnable
        private void OnEnable()
        {
            // _carEnterAction Enable
            _carEnterAction.Enable();

            // _carExitAction Enable
            _carExitAction.Enable();

        } // close private void OnEnable

        // private void OnDisable
        private void OnDisable()
        {
            // _carEnterAction Disable
            _carEnterAction.Disable();

            // _carExitAction Disable
            _carExitAction.Disable();  

        } // close private void OnDisable
                
        // private void Start
        private void Start() 
        {
            //_sedanSmall02Entry = this;
            
            // _sedanSmall02Script is GetComponent SedanSmall02Controller
            _sedanSmall02Script = GetComponent<SedanSmall02Controller>();

            // _sedanSmall02Script enabled is false
            _sedanSmall02Script.enabled = false;
            
            // _sedanSmall02Script is GetComponentInChildren
            _sedanSmall02Camera = GetComponentInChildren<Camera>();

            // _sedanSmall02Camera enabled is false
            _sedanSmall02Camera.enabled = false;

            // _sedanSmall02CameraAudioListener is GetComponentInChildren AudioListener
            _sedanSmall02CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _sedanSmall02CameraAudioListener enabled is false
            _sedanSmall02CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName SedanSmall02_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("SedanSmall02_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _sedanSM02Compass enabled is false
            _sedanSM02Compass.enabled = false;

            // _sedanSM02Compass compassEnabled is false
            _sedanSM02Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The SedanSmall02 compass is disabled");

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if_carEnterAction triggered
            if (_carEnterAction.triggered)
            {
                // _enterButton is true
                _enterButton = true;

                // _exitButton is false
                _exitButton = false;

            } // close if_carEnterAction triggered

            // if _carExitAction triggered
            if (_carExitAction.triggered)
            {
                // _enterButton is false
                _enterButton = false;

                // _exitButton is true
                _exitButton = true;

            } // close if _carExitAction triggered
            
            // if _inSedanSmall02 and Input GetKey KeyCode _exitKey
            if (_inSedanSmall02 && _exitButton == true)
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _sedanSmall02Script enabled is false
                _sedanSmall02Script.enabled = false;
                
                // _sedanSmall02Camera enabled is false
                _sedanSmall02Camera.enabled = false;

                // _sedanSmall02CameraAudioListener enabled is false
                _sedanSmall02CameraAudioListener.enabled = false; 

                // _inSedanSmall02 is false
                _inSedanSmall02 = false;

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true 
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled");

                // _sedanSM02Compass enabled is false
                _sedanSM02Compass.enabled = false;

                // _sedanSM02Compass compassEnabled is false
                _sedanSM02Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The SedanSmall02 compass is disabled");         

            } // close if _inSedanSmall02 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inSedanSmall02 and gameObject tag is Player
            if (!_inSedanSmall02 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inSedanSmall02 and gameObject tag is Player
            
            // if not _inSedanSmall02 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inSedanSmall02 && other.gameObject.tag == "Player" && _enterButton == true)
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _sedanSmall02 transform
                _player.transform.parent = _sedanSmall02.transform;

                // _sedanSmall02Script enabled is true
                _sedanSmall02Script.enabled = true;
                
                // _sedanSmall02Camera enabled is true
                _sedanSmall02Camera.enabled = true;

                // _sedanSmall02CameraAudioListener enabled is true
                _sedanSmall02CameraAudioListener.enabled = true; 

                // _inSedanSmall02 is true
                _inSedanSmall02 = true;

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled"); 

                // _sedanSM02Compass enabled is true
                _sedanSM02Compass.enabled = true;

                // _sedanSM02Compass compassEnabled is true
                _sedanSM02Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The SedanSmall02 compass is enabled");                

            } // close if not _inSedanSmall02 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class SedanSmall02Entry  

} // close namespace VehiclesControl
