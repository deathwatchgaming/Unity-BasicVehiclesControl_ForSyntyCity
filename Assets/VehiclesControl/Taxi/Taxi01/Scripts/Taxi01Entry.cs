/*
 * File: Taxi 01 Entry
 * Name: Taxi01Entry.cs
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

    // public class Taxi01Entry 
    public class Taxi01Entry : MonoBehaviour
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

            [Tooltip("The taxi01 game object")]
            // GameObject _taxi01
            [SerializeField] private GameObject _taxi01;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inTaxi01 is false
            [SerializeField] private bool _inTaxi01 = false;
        
        // Taxi01Controller _taxi01Script
        private Taxi01Controller _taxi01Script;

        // Camera _taxi01Camera
        private Camera _taxi01Camera;

        // AudioListener _taxi01CameraAudioListener
        private AudioListener _taxi01CameraAudioListener; 

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
            // _taxi01Script is GetComponent Taxi01Controller
            _taxi01Script = GetComponent<Taxi01Controller>();

            // _taxi01Script enabled is false
            _taxi01Script.enabled = false;
            
            // _taxi01Script is GetComponentInChildren
            _taxi01Camera = GetComponentInChildren<Camera>();

            // _taxi01Camera enabled is false
            _taxi01Camera.enabled = false;

            // _taxi01CameraAudioListener is GetComponentInChildren AudioListener
            _taxi01CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _taxi01CameraAudioListener enabled is false
            _taxi01CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName Taxi01_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("Taxi01_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inTaxi01 and Input GetKey KeyCode _exitKey
            if (_inTaxi01 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _taxi01Script enabled is false
                _taxi01Script.enabled = false;
                
                // _taxi01Camera enabled is false
                _taxi01Camera.enabled = false;

                // _taxi01CameraAudioListener enabled is false
                _taxi01CameraAudioListener.enabled = false; 

                // _inTaxi01 is false
                _inTaxi01 = false;

            } // close if _inTaxi01 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inTaxi01 and gameObject tag is Player
            if (!_inTaxi01 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inTaxi01 and gameObject tag is Player
            
            // if not _inTaxi01 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inTaxi01 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _taxi01 transform
                _player.transform.parent = _taxi01.transform;

                // _taxi01Script enabled is true
                _taxi01Script.enabled = true;
                
                // _taxi01Camera enabled is true
                _taxi01Camera.enabled = true;

                // _taxi01CameraAudioListener enabled is true
                _taxi01CameraAudioListener.enabled = true; 

                // _inTaxi01 is true
                _inTaxi01 = true;

            } // close if not _inTaxi01 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class Taxi01Entry  

} // close namespace VehiclesControl
