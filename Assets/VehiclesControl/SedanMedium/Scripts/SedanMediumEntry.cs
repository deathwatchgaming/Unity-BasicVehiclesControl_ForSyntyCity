/*
 * File: SedanMedium Entry
 * Name: SedanMediumEntry.cs
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

    // public class SedanMediumEntry 
    public class SedanMediumEntry : MonoBehaviour
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

            [Tooltip("The sedanMedium game object")]
            // GameObject _sedanMedium
            [SerializeField] private GameObject _sedanMedium;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inSedanMedium is false
            [SerializeField] private bool _inSedanMedium = false;
        
        // SedanMediumController _sedanMediumScript
        private SedanMediumController _sedanMediumScript;

        // Camera _sedanMediumCamera
        private Camera _sedanMediumCamera;

        // AudioListener _sedanMediumCameraAudioListener
        private AudioListener _sedanMediumCameraAudioListener; 

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
            // _sedanMediumScript is GetComponent SedanMediumController
            _sedanMediumScript = GetComponent<SedanMediumController>();

            // _sedanMediumScript enabled is false
            _sedanMediumScript.enabled = false;
            
            // _sedanMediumScript is GetComponentInChildren
            _sedanMediumCamera = GetComponentInChildren<Camera>();

            // _sedanMediumCamera enabled is false
            _sedanMediumCamera.enabled = false;

            // _sedanMediumCameraAudioListener is GetComponentInChildren AudioListener
            _sedanMediumCameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _sedanMediumCameraAudioListener enabled is false
            _sedanMediumCameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName SedanMedium_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("SedanMedium_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inSedanMedium and Input GetKey KeyCode _exitKey
            if (_inSedanMedium && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _sedanMediumScript enabled is false
                _sedanMediumScript.enabled = false;
                
                // _sedanMediumCamera enabled is false
                _sedanMediumCamera.enabled = false;

                // _sedanMediumCameraAudioListener enabled is false
                _sedanMediumCameraAudioListener.enabled = false; 

                // _inSedanMedium is false
                _inSedanMedium = false;

            } // close if _inSedanMedium and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inSedanMedium and gameObject tag is Player
            if (!_inSedanMedium && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inSedanMedium and gameObject tag is Player
            
            // if not _inSedanMedium and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inSedanMedium && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _sedanMedium transform
                _player.transform.parent = _sedanMedium.transform;

                // _sedanMediumScript enabled is true
                _sedanMediumScript.enabled = true;
                
                // _sedanMediumCamera enabled is true
                _sedanMediumCamera.enabled = true;

                // _sedanMediumCameraAudioListener enabled is true
                _sedanMediumCameraAudioListener.enabled = true; 

                // _inSedanMedium is true
                _inSedanMedium = true;

            } // close if not _inSedanMedium and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class SedanMediumEntry  

} // close namespace VehiclesControl
