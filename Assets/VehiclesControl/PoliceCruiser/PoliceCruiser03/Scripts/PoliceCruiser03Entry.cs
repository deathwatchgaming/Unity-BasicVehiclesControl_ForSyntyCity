/*
 * File: Police Cruiser 03 Entry
 * Name: PoliceCruiser03Entry.cs
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

    // public class PoliceCruiser03Entry 
    public class PoliceCruiser03Entry : MonoBehaviour
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

            [Tooltip("The police cruiser 03 game object")]
            // GameObject _policeCruiser03
            [SerializeField] private GameObject _policeCruiser03;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inPoliceCruiser03 is false
            [SerializeField] private bool _inPoliceCruiser03 = false;
        
        // PoliceCruiser03Controller _policeCruiser03Script
        private PoliceCruiser03Controller _policeCruiser03Script;
        
        // Camera _policeCruiser03Camera
        private Camera _policeCruiser03Camera;

        // AudioListener _policeCruiser03CameraAudioListener
        private AudioListener _policeCruiser03CameraAudioListener; 

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
            // _policeCruiser03Script is GetComponent PoliceCruiser03Controller
            _policeCruiser03Script = GetComponent<PoliceCruiser03Controller>();

            // _policeCruiser03Script enabled is false
            _policeCruiser03Script.enabled = false;
            
            // _policeCruiser03Camera is GetComponentInChildren Camera
            _policeCruiser03Camera = GetComponentInChildren<Camera>();
            
            // _policeCruiser03Camera enabled is false
            _policeCruiser03Camera.enabled = false;
           
            // _policeCruiser03CameraAudioListener is GetComponentInChildren AudioListener
            _policeCruiser03CameraAudioListener = GetComponentInChildren<AudioListener>();

            // _policeCruiser03CameraAudioListener enabled is false
            _policeCruiser03CameraAudioListener.enabled = false;

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName PoliceCruiser03_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("PoliceCruiser03_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inPoliceCruiser03 and Input GetKey KeyCode _exitKey
            if (_inPoliceCruiser03 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _policeCruiser03Script enabled is false
                _policeCruiser03Script.enabled = false;
                
                // _policeCruiser03Camera enabled is false
                _policeCruiser03Camera.enabled = false;

                // _policeCruiser03CameraAudioListener enabled is false
                _policeCruiser03CameraAudioListener.enabled = false;

                // _inPoliceCruiser03 is false
                _inPoliceCruiser03 = false;

            } // close if _inPoliceCruiser03 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inPoliceCruiser03 and gameObject tag is Player
            if (!_inPoliceCruiser03 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inPoliceCruiser03 and gameObject tag is Player
            
            // if not _inPoliceCruiser03 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inPoliceCruiser03 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _policeCruiser03 transform
                _player.transform.parent = _policeCruiser03.transform;

                // _policeCruiser03Script enabled is true
                _policeCruiser03Script.enabled = true;
                
                // _policeCruiser03Camera enabled is true
                _policeCruiser03Camera.enabled = true;

                // _policeCruiser03CameraAudioListener enabled is true
                _policeCruiser03CameraAudioListener.enabled = true;

                // _inPoliceCruiser03 is true
                _inPoliceCruiser03 = true;

            } // close if not _inPoliceCruiser03 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class PoliceCruiser03Entry  

} // close namespace VehiclesControl
