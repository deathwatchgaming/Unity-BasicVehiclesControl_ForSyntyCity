/*
 * File: Police Cruiser 01 Entry
 * Name: PoliceCruiser01Entry.cs
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

    // public class PoliceCruiser01Entry 
    public class PoliceCruiser01Entry : MonoBehaviour
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

            [Tooltip("The police cruiser 01 game object")]
            // GameObject _policeCruiser01
            [SerializeField] private GameObject _policeCruiser01;

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
            // bool _inPoliceCruiser01 is false
            [SerializeField] private bool _inPoliceCruiser01 = false;
        
        // PoliceCruiser01Controller _policeCruiser01Script
        private PoliceCruiser01Controller _policeCruiser01Script;
        
        // Camera _policeCruiser01Camera
        private Camera _policeCruiser01Camera;

        // AudioListener _policeCruiser01CameraAudioListener
        private AudioListener _policeCruiser01CameraAudioListener; 

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
            // _policeCruiser01Script is GetComponent PoliceCruiser01Controller
            _policeCruiser01Script = GetComponent<PoliceCruiser01Controller>();

            // _policeCruiser01Script enabled is false
            _policeCruiser01Script.enabled = false;
            
            // _policeCruiser01Camera is GetComponentInChildren Camera
            _policeCruiser01Camera = GetComponentInChildren<Camera>();
            
            // _policeCruiser01Camera enabled is false
            _policeCruiser01Camera.enabled = false;
           
            // _policeCruiser01CameraAudioListener is GetComponentInChildren AudioListener
            _policeCruiser01CameraAudioListener = GetComponentInChildren<AudioListener>();

            // _policeCruiser01CameraAudioListener enabled is false
            _policeCruiser01CameraAudioListener.enabled = false;

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName PoliceCruiser01_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("PoliceCruiser01_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inPoliceCruiser01 and Input GetKey KeyCode _exitKey
            if (_inPoliceCruiser01 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _policeCruiser01Script enabled is false
                _policeCruiser01Script.enabled = false;
                
                // _policeCruiser01Camera enabled is false
                _policeCruiser01Camera.enabled = false;

                // _policeCruiser01CameraAudioListener enabled is false
                _policeCruiser01CameraAudioListener.enabled = false;

                // _inPoliceCruiser01 is false
                _inPoliceCruiser01 = false;

            } // close if _inPoliceCruiser01 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inPoliceCruiser01 and gameObject tag is Player
            if (!_inPoliceCruiser01 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inPoliceCruiser01 and gameObject tag is Player
            
            // if not _inPoliceCruiser01 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inPoliceCruiser01 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _policeCruiser01 transform
                _player.transform.parent = _policeCruiser01.transform;

                // _policeCruiser01Script enabled is true
                _policeCruiser01Script.enabled = true;
                
                // _policeCruiser01Camera enabled is true
                _policeCruiser01Camera.enabled = true;

                // _policeCruiser01CameraAudioListener enabled is true
                _policeCruiser01CameraAudioListener.enabled = true;

                // _inPoliceCruiser01 is true
                _inPoliceCruiser01 = true;

            } // close if not _inPoliceCruiser01 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class PoliceCruiser01Entry  

} // close namespace VehiclesControl
