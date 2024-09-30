/*
 * File: SedanMedium 03 Entry
 * Name: SedanMedium03Entry.cs
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

    // public class SedanMedium03Entry 
    public class SedanMedium03Entry : MonoBehaviour
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

            [Tooltip("The sedanMedium03 game object")]
            // GameObject _sedanMedium03
            [SerializeField] private GameObject _sedanMedium03;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inSedanMedium03 is false
            [SerializeField] private bool _inSedanMedium03 = false;
        
        // SedanMedium03Controller _sedanMedium03Script
        private SedanMedium03Controller _sedanMedium03Script;

        // Camera _sedanMedium03Camera
        private Camera _sedanMedium03Camera;

        // AudioListener _sedanMedium03CameraAudioListener
        private AudioListener _sedanMedium03CameraAudioListener; 

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
            // _sedanMedium03Script is GetComponent SedanMedium03Controller
            _sedanMedium03Script = GetComponent<SedanMedium03Controller>();

            // _sedanMedium03Script enabled is false
            _sedanMedium03Script.enabled = false;
            
            // _sedanMedium03Script is GetComponentInChildren
            _sedanMedium03Camera = GetComponentInChildren<Camera>();

            // _sedanMedium03Camera enabled is false
            _sedanMedium03Camera.enabled = false;

            // _sedanMedium03CameraAudioListener is GetComponentInChildren AudioListener
            _sedanMedium03CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _sedanMedium03CameraAudioListener enabled is false
            _sedanMedium03CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName SedanMedium03_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("SedanMedium03_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inSedanMedium03 and Input GetKey KeyCode _exitKey
            if (_inSedanMedium03 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _sedanMedium03Script enabled is false
                _sedanMedium03Script.enabled = false;
                
                // _sedanMedium03Camera enabled is false
                _sedanMedium03Camera.enabled = false;

                // _sedanMedium03CameraAudioListener enabled is false
                _sedanMedium03CameraAudioListener.enabled = false; 

                // _inSedanMedium03 is false
                _inSedanMedium03 = false;

            } // close if _inSedanMedium03 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inSedanMedium03 and gameObject tag is Player
            if (!_inSedanMedium03 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inSedanMedium03 and gameObject tag is Player
            
            // if not _inSedanMedium03 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inSedanMedium03 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _sedanMedium03 transform
                _player.transform.parent = _sedanMedium03.transform;

                // _sedanMedium03Script enabled is true
                _sedanMedium03Script.enabled = true;
                
                // _sedanMedium03Camera enabled is true
                _sedanMedium03Camera.enabled = true;

                // _sedanMedium03CameraAudioListener enabled is true
                _sedanMedium03CameraAudioListener.enabled = true; 

                // _inSedanMedium03 is true
                _inSedanMedium03 = true;

            } // close if not _inSedanMedium03 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class SedanMedium03Entry  

} // close namespace VehiclesControl
