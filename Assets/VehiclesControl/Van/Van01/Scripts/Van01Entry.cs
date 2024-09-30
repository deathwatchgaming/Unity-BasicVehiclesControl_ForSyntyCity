/*
 * File: Van 01 Entry
 * Name: Van01Entry.cs
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

    // public class Van01Entry 
    public class Van01Entry : MonoBehaviour
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

            [Tooltip("The van01 game object")]
            // GameObject _van01
            [SerializeField] private GameObject _van01;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inVan01 is false
            [SerializeField] private bool _inVan01 = false;
        
        // Van01Controller _van01Script
        private Van01Controller _van01Script;

        // Camera _van01Camera
        private Camera _van01Camera;

        // AudioListener _van01CameraAudioListener
        private AudioListener _van01CameraAudioListener; 

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
            // _van01Script is GetComponent Van01Controller
            _van01Script = GetComponent<Van01Controller>();

            // _van01Script enabled is false
            _van01Script.enabled = false;
            
            // _van01Script is GetComponentInChildren Camera
            _van01Camera = GetComponentInChildren<Camera>();

            // _van01Camera enabled is false
            _van01Camera.enabled = false;
           
            // _van01CameraAudioListener is GetComponentInChildren AudioListener
            _van01CameraAudioListener = GetComponentInChildren<AudioListener>();

            // _van01CameraAudioListener enabled is false
            _van01CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName Van01_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("Van01_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inVan01 and Input GetKey KeyCode _exitKey
            if (_inVan01 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _van01Script enabled is false
                _van01Script.enabled = false;

                // _van01Camera enabled is false
                _van01Camera.enabled = false;

                // _van01CameraAudioListener enabled is false
                _van01CameraAudioListener.enabled = false; 

                // _inVan01 is false
                _inVan01 = false;

            } // close if _inVan01 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inVan01 and gameObject tag is Player
            if (!_inVan01 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inVan01 and gameObject tag is Player
            
            // if not _inVan01 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inVan01 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _van01 transform
                _player.transform.parent = _van01.transform;

                // _van01Script enabled is true
                _van01Script.enabled = true;

                // _van01Camera enabled is true
                _van01Camera.enabled = true;

                // _van01CameraAudioListener enabled is true
                _van01CameraAudioListener.enabled = true; 

                // _inVan01 is true
                _inVan01 = true;

            } // close if not _inVan01 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class Van01Entry  

} // close namespace VehiclesControl
