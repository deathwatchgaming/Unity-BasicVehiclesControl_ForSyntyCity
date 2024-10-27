/*
 * File: Police Cruiser 04 Entry
 * Name: PoliceCruiser04Entry.cs
 * Author: DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 2021+ - 2022+
 */

// using
using UnityEngine;
using System.Collections;

// namespace VehiclesControl
namespace VehiclesControl
{
    // RequireComponent typeof BoxCollider
    [RequireComponent(typeof(BoxCollider))]

    // public class PoliceCruiser04Entry 
    public class PoliceCruiser04Entry : MonoBehaviour
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

            [Tooltip("The police cruiser 04 game object")]
            // GameObject _policeCruiser04
            [SerializeField] private GameObject _policeCruiser04;

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
            // bool _inPoliceCruiser04 is false
            [SerializeField] private bool _inPoliceCruiser04 = false;
        
        // PoliceCruiser04Controller _policeCruiser04Script
        private PoliceCruiser04Controller _policeCruiser04Script;
        
        // Camera _policeCruiser04Camera
        private Camera _policeCruiser04Camera;

        // AudioListener _policeCruiser04CameraAudioListener
        private AudioListener _policeCruiser04CameraAudioListener; 

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
            // _policeCruiser04Script is GetComponent PoliceCruiser04Controller
            _policeCruiser04Script = GetComponent<PoliceCruiser04Controller>();

            // _policeCruiser04Script enabled is false
            _policeCruiser04Script.enabled = false;
            
            // _policeCruiser04Camera is GetComponentInChildren Camera
            _policeCruiser04Camera = GetComponentInChildren<Camera>();
            
            // _policeCruiser04Camera enabled is false
            _policeCruiser04Camera.enabled = false;
           
            // _policeCruiser04CameraAudioListener is GetComponentInChildren AudioListener
            _policeCruiser04CameraAudioListener = GetComponentInChildren<AudioListener>();

            // _policeCruiser04CameraAudioListener enabled is false
            _policeCruiser04CameraAudioListener.enabled = false;

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName PoliceCruiser04_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("PoliceCruiser04_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inPoliceCruiser04 and Input GetKey KeyCode _exitKey
            if (_inPoliceCruiser04 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _policeCruiser04Script enabled is false
                _policeCruiser04Script.enabled = false;
                
                // _policeCruiser04Camera enabled is false
                _policeCruiser04Camera.enabled = false;

                // _policeCruiser04CameraAudioListener enabled is false
                _policeCruiser04CameraAudioListener.enabled = false;

                // _inPoliceCruiser04 is false
                _inPoliceCruiser04 = false;

            } // close if _inPoliceCruiser04 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inPoliceCruiser04 and gameObject tag is Player
            if (!_inPoliceCruiser04 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inPoliceCruiser04 and gameObject tag is Player
            
            // if not _inPoliceCruiser04 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inPoliceCruiser04 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _policeCruiser04 transform
                _player.transform.parent = _policeCruiser04.transform;

                // _policeCruiser04Script enabled is true
                _policeCruiser04Script.enabled = true;
                
                // _policeCruiser04Camera enabled is true
                _policeCruiser04Camera.enabled = true;

                // _policeCruiser04CameraAudioListener enabled is true
                _policeCruiser04CameraAudioListener.enabled = true;

                // _inPoliceCruiser04 is true
                _inPoliceCruiser04 = true;

            } // close if not _inPoliceCruiser04 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class PoliceCruiser04Entry  

} // close namespace VehiclesControl
