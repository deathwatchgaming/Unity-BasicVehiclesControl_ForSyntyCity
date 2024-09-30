/*
 * File: SedanLarge 03 Entry
 * Name: SedanLarge03Entry.cs
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

    // public class SedanLarge03Entry 
    public class SedanLarge03Entry : MonoBehaviour
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

            [Tooltip("The sedanLarge03 game object")]
            // GameObject _sedanLarge03
            [SerializeField] private GameObject _sedanLarge03;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inSedanLarge03 is false
            [SerializeField] private bool _inSedanLarge03 = false;
        
        // SedanLarge03Controller _sedanLarge03Script
        private SedanLarge03Controller _sedanLarge03Script;

        // Camera _sedanLarge03Camera
        private Camera _sedanLarge03Camera;

        // AudioListener _sedanLarge03CameraAudioListener
        private AudioListener _sedanLarge03CameraAudioListener; 

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
            // _sedanLarge03Script is GetComponent SedanLarge03Controller
            _sedanLarge03Script = GetComponent<SedanLarge03Controller>();

            // _sedanLarge03Script enabled is false
            _sedanLarge03Script.enabled = false;
            
            // _sedanLarge03Script is GetComponentInChildren
            _sedanLarge03Camera = GetComponentInChildren<Camera>();

            // _sedanLarge03Camera enabled is false
            _sedanLarge03Camera.enabled = false;

            // _sedanLarge03CameraAudioListener is GetComponentInChildren AudioListener
            _sedanLarge03CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _sedanLarge03CameraAudioListener enabled is false
            _sedanLarge03CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName SedanLarge03_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("SedanLarge03_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inSedanLarge03 and Input GetKey KeyCode _exitKey
            if (_inSedanLarge03 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _sedanLarge03Script enabled is false
                _sedanLarge03Script.enabled = false;
                
                // _sedanLarge03Camera enabled is false
                _sedanLarge03Camera.enabled = false;

                // _sedanLarge03CameraAudioListener enabled is false
                _sedanLarge03CameraAudioListener.enabled = false; 

                // _inSedanLarge03 is false
                _inSedanLarge03 = false;

            } // close if _inSedanLarge03 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inSedanLarge03 and gameObject tag is Player
            if (!_inSedanLarge03 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inSedanLarge03 and gameObject tag is Player
            
            // if not _inSedanLarge03 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inSedanLarge03 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _sedanLarge03 transform
                _player.transform.parent = _sedanLarge03.transform;

                // _sedanLarge03Script enabled is true
                _sedanLarge03Script.enabled = true;
                
                // _sedanLarge03Camera enabled is true
                _sedanLarge03Camera.enabled = true;

                // _sedanLarge03CameraAudioListener enabled is true
                _sedanLarge03CameraAudioListener.enabled = true; 

                // _inSedanLarge03 is true
                _inSedanLarge03 = true;

            } // close if not _inSedanLarge03 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class SedanLarge03Entry  

} // close namespace VehiclesControl
