/*
 * File: SedanSmall 03 Entry (New Input System)
 * Name: SedanSmall03Entry.cs
 * Author: DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 6+
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

    // public class SedanSmall03Entry 
    public class SedanSmall03Entry : MonoBehaviour
    {   
        // Game Objects
        [Header("Game Objects")]

            [Tooltip("The sedanSmall03 game object")]
            // GameObject _sedanSmall03
            [SerializeField] private GameObject _sedanSmall03;

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
            // bool _inSedanSmall03 is false
            [SerializeField] private bool _inSedanSmall03 = false;

        // Compass
        [Header("Compass")]

            [Tooltip("The player compass")]
            // PlayerCompass _playerCompass
            [SerializeField] private PlayerCompass _playerCompass;
            
            [Tooltip("The sedan small 03 compass")]
            // SedanSmall03Compass _sedanSM03Compass
            [SerializeField] private SedanSmall03Compass _sedanSM03Compass;  

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
        
        // SedanSmall03Controller _sedanSmall03Script
        private SedanSmall03Controller _sedanSmall03Script;

        // Camera _sedanSmall03Camera
        private Camera _sedanSmall03Camera;

        // AudioListener _sedanSmall03CameraAudioListener
        private AudioListener _sedanSmall03CameraAudioListener; 

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

        //public static SedanSmall03Entry _sedanSmall03Entry;

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
            //_sedanSmall03Entry = this;

            // _sedanSmall03Script is GetComponent SedanSmall03Controller
            _sedanSmall03Script = GetComponent<SedanSmall03Controller>();

            // _sedanSmall03Script enabled is false
            _sedanSmall03Script.enabled = false;
            
            // _sedanSmall03Script is GetComponentInChildren
            _sedanSmall03Camera = GetComponentInChildren<Camera>();

            // _sedanSmall03Camera enabled is false
            _sedanSmall03Camera.enabled = false;

            // _sedanSmall03CameraAudioListener is GetComponentInChildren AudioListener
            _sedanSmall03CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _sedanSmall03CameraAudioListener enabled is false
            _sedanSmall03CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName SedanSmall03_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("SedanSmall03_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _sedanSM03Compass enabled is false
            _sedanSM03Compass.enabled = false;

            // _sedanSM03Compass compassEnabled is false
            _sedanSM03Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The SedanSmall03 compass is disabled");

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
            
            // if _inSedanSmall03 and Input GetKey KeyCode _exitKey
            if (_inSedanSmall03 && _exitButton == true)
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _sedanSmall03Script enabled is false
                _sedanSmall03Script.enabled = false;
                
                // _sedanSmall03Camera enabled is false
                _sedanSmall03Camera.enabled = false;

                // _sedanSmall03CameraAudioListener enabled is false
                _sedanSmall03CameraAudioListener.enabled = false; 

                // _inSedanSmall03 is false
                _inSedanSmall03 = false;

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true 
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled");

                // _sedanSM03Compass enabled is false
                _sedanSM03Compass.enabled = false;

                // _sedanSM03Compass compassEnabled is false
                _sedanSM03Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The SedanSmall03 compass is disabled");         

            } // close if _inSedanSmall03 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inSedanSmall03 and gameObject tag is Player
            if (!_inSedanSmall03 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inSedanSmall03 and gameObject tag is Player
            
            // if not _inSedanSmall03 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inSedanSmall03 && other.gameObject.tag == "Player" && _enterButton == true)
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _sedanSmall03 transform
                _player.transform.parent = _sedanSmall03.transform;

                // _sedanSmall03Script enabled is true
                _sedanSmall03Script.enabled = true;
                
                // _sedanSmall03Camera enabled is true
                _sedanSmall03Camera.enabled = true;

                // _sedanSmall03CameraAudioListener enabled is true
                _sedanSmall03CameraAudioListener.enabled = true; 

                // _inSedanSmall03 is true
                _inSedanSmall03 = true;

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled"); 

                // _sedanSM03Compass enabled is true
                _sedanSM03Compass.enabled = true;

                // _sedanSM03Compass compassEnabled is true
                _sedanSM03Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The SedanSmall03 compass is enabled");                

            } // close if not _inSedanSmall03 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class SedanSmall03Entry  

} // close namespace VehiclesControl
