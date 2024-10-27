/*
 * File: SedanSmall 02 Entry
 * Name: SedanSmall02Entry.cs
 * Author: DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 6+
 */

// using
using UnityEngine;
using System.Collections;

// namespace VehiclesControl
namespace VehiclesControl
{
    // RequireComponent typeof BoxCollider
    [RequireComponent(typeof(BoxCollider))]

    // public class SedanSmall02Entry 
    public class SedanSmall02Entry : MonoBehaviour
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
        
        // private void Start
        private void Start() 
        {
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

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inSedanSmall02 and Input GetKey KeyCode _exitKey
            if (_inSedanSmall02 && Input.GetKey(_exitKey))
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
            if (!_inSedanSmall02 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
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
