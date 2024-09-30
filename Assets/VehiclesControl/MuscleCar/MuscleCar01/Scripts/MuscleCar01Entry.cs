/*
 * File: MuscleCar 01 Entry
 * Name: MuscleCar01Entry.cs
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

    // public class MuscleCar01Entry 
    public class MuscleCar01Entry : MonoBehaviour
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

            [Tooltip("The muscleCar01 game object")]
            // GameObject _muscleCar01
            [SerializeField] private GameObject _muscleCar01;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inMuscleCar01 is false
            [SerializeField] private bool _inMuscleCar01 = false;
        
        // MuscleCar01Controller _muscleCar01Script
        private MuscleCar01Controller _muscleCar01Script;

        // Camera _muscleCar01Camera
        private Camera _muscleCar01Camera;

        // AudioListener _muscleCar01CameraAudioListener
        private AudioListener _muscleCar01CameraAudioListener; 

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
            // _muscleCar01Script is GetComponent MuscleCar01Controller
            _muscleCar01Script = GetComponent<MuscleCar01Controller>();

            // _muscleCar01Script enabled is false
            _muscleCar01Script.enabled = false;
            
            // _muscleCar01Script is GetComponentInChildren
            _muscleCar01Camera = GetComponentInChildren<Camera>();

            // _muscleCar01Camera enabled is false
            _muscleCar01Camera.enabled = false;

            // _muscleCar01CameraAudioListener is GetComponentInChildren AudioListener
            _muscleCar01CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _muscleCar01CameraAudioListener enabled is false
            _muscleCar01CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName MuscleCar01_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("MuscleCar01_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inMuscleCar01 and Input GetKey KeyCode _exitKey
            if (_inMuscleCar01 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _muscleCar01Script enabled is false
                _muscleCar01Script.enabled = false;
                
                // _muscleCar01Camera enabled is false
                _muscleCar01Camera.enabled = false;

                // _muscleCar01CameraAudioListener enabled is false
                _muscleCar01CameraAudioListener.enabled = false; 

                // _inMuscleCar01 is false
                _inMuscleCar01 = false;

            } // close if _inMuscleCar01 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inMuscleCar01 and gameObject tag is Player
            if (!_inMuscleCar01 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inMuscleCar01 and gameObject tag is Player
            
            // if not _inMuscleCar01 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inMuscleCar01 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _muscleCar01 transform
                _player.transform.parent = _muscleCar01.transform;

                // _muscleCar01Script enabled is true
                _muscleCar01Script.enabled = true;
                
                // _muscleCar01Camera enabled is true
                _muscleCar01Camera.enabled = true;

                // _muscleCar01CameraAudioListener enabled is true
                _muscleCar01CameraAudioListener.enabled = true; 

                // _inMuscleCar01 is true
                _inMuscleCar01 = true;

            } // close if not _inMuscleCar01 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class MuscleCar01Entry  

} // close namespace VehiclesControl
