/*
 * File: SedanSmall 04 Entry (New Input System)
 * Name: SedanSmall04Entry.cs
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

    // public class SedanSmall04Entry 
    public class SedanSmall04Entry : MonoBehaviour
    {   
        // Game Objects
        [Header("Game Objects")]

            [Tooltip("The sedanSmall04 game object")]
            // GameObject _sedanSmall04
            [SerializeField] private GameObject _sedanSmall04;

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
            // bool _inSedanSmall04 is false
            [SerializeField] private bool _inSedanSmall04 = false;
 
        // Compass
        [Header("Compass")]

            [Tooltip("The player compass")]
            // PlayerCompass _playerCompass
            [SerializeField] private PlayerCompass _playerCompass;
            
            [Tooltip("The sedan small 04 compass")]
            // SedanSmall04Compass _sedanSM01Compass
            [SerializeField] private SedanSmall04Compass _sedanSM04Compass;  

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
        
        // SedanSmall04Controller _sedanSmall04Script
        private SedanSmall04Controller _sedanSmall04Script;

        // Camera _sedanSmall04Camera
        private Camera _sedanSmall04Camera;

        // AudioListener _sedanSmall04CameraAudioListener
        private AudioListener _sedanSmall04CameraAudioListener; 

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

        //public static SedanSmall04Entry _sedanSmall04Entry;

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
            //_sedanSmall04Entry = this;

            // _sedanSmall04Script is GetComponent SedanSmall04Controller
            _sedanSmall04Script = GetComponent<SedanSmall04Controller>();

            // _sedanSmall04Script enabled is false
            _sedanSmall04Script.enabled = false;
            
            // _sedanSmall04Script is GetComponentInChildren
            _sedanSmall04Camera = GetComponentInChildren<Camera>();

            // _sedanSmall04Camera enabled is false
            _sedanSmall04Camera.enabled = false;

            // _sedanSmall04CameraAudioListener is GetComponentInChildren AudioListener
            _sedanSmall04CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _sedanSmall04CameraAudioListener enabled is false
            _sedanSmall04CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName SedanSmall04_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("SedanSmall04_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _sedanSM04Compass enabled is false
            _sedanSM04Compass.enabled = false;

            // _sedanSM04Compass compassEnabled is false
            _sedanSM04Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The SedanSmall04 compass is disabled");

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
            
            // if _inSedanSmall04 and Input GetKey KeyCode _exitKey
            if (_inSedanSmall04 && _exitButton == true)
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _sedanSmall04Script enabled is false
                _sedanSmall04Script.enabled = false;
                
                // _sedanSmall04Camera enabled is false
                _sedanSmall04Camera.enabled = false;

                // _sedanSmall04CameraAudioListener enabled is false
                _sedanSmall04CameraAudioListener.enabled = false; 

                // _inSedanSmall04 is false
                _inSedanSmall04 = false;

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true 
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled");

                // _sedanSM04Compass enabled is false
                _sedanSM04Compass.enabled = false;

                // _sedanSM04Compass compassEnabled is false
                _sedanSM04Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The SedanSmall04 compass is disabled");         

            } // close if _inSedanSmall04 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inSedanSmall04 and gameObject tag is Player
            if (!_inSedanSmall04 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inSedanSmall04 and gameObject tag is Player
            
            // if not _inSedanSmall04 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inSedanSmall04 && other.gameObject.tag == "Player" && _enterButton == true)
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _sedanSmall04 transform
                _player.transform.parent = _sedanSmall04.transform;

                // _sedanSmall04Script enabled is true
                _sedanSmall04Script.enabled = true;
                
                // _sedanSmall04Camera enabled is true
                _sedanSmall04Camera.enabled = true;

                // _sedanSmall04CameraAudioListener enabled is true
                _sedanSmall04CameraAudioListener.enabled = true; 

                // _inSedanSmall04 is true
                _inSedanSmall04 = true;

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled"); 

                // _sedanSM04Compass enabled is true
                _sedanSM04Compass.enabled = true;

                // _sedanSM04Compass compassEnabled is true
                _sedanSM04Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The SedanSmall04 compass is enabled");                

            } // close if not _inSedanSmall04 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class SedanSmall04Entry  

} // close namespace VehiclesControl
