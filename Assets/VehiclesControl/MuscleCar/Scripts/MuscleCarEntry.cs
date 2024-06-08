/*
 * File: MuscleCar Entry
 * Name: MuscleCarEntry.cs
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

    // public class MuscleCarEntry 
    public class MuscleCarEntry : MonoBehaviour
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

            [Tooltip("The muscleCar game object")]
            // GameObject _muscleCar
            [SerializeField] private GameObject _muscleCar;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inMuscleCar is false
            [SerializeField] private bool _inMuscleCar = false;
        
        // MuscleCarController _muscleCarScript
        private MuscleCarController _muscleCarScript;

        // Camera _muscleCarCamera
        private Camera _muscleCarCamera;

        // AudioListener _muscleCarCameraAudioListener
        private AudioListener _muscleCarCameraAudioListener; 

        // Rigidbody _rigidbody
        private Rigidbody _rigidbody;        

        // private void Start
        private void Start() 
        {
            // _muscleCarScript is GetComponent MuscleCarController
            _muscleCarScript = GetComponent<MuscleCarController>();

            // _muscleCarScript enabled is false
            _muscleCarScript.enabled = false;
            
            // _muscleCarScript is GetComponentInChildren
            _muscleCarCamera = GetComponentInChildren<Camera>();

            // _muscleCarCamera enabled is false
            _muscleCarCamera.enabled = false;

            // _muscleCarCameraAudioListener is GetComponentInChildren AudioListener
            _muscleCarCameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _muscleCarCameraAudioListener enabled is false
            _muscleCarCameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // _interfaceTextObject is GameObject Find MuscleCar_EntryKey
            _interfaceTextObject = GameObject.Find("MuscleCar_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inMuscleCar and Input GetKey KeyCode _exitKey
            if (_inMuscleCar && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _muscleCarScript enabled is false
                _muscleCarScript.enabled = false;
                
                // _muscleCarCamera enabled is false
                _muscleCarCamera.enabled = false;

                // _muscleCarCameraAudioListener enabled is false
                _muscleCarCameraAudioListener.enabled = false; 

                // _inMuscleCar is false
                _inMuscleCar = false;

            } // close if _inMuscleCar and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inMuscleCar and gameObject tag is Player
            if (!_inMuscleCar && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inMuscleCar and gameObject tag is Player
            
            // if not _inMuscleCar and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inMuscleCar && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _muscleCar transform
                _player.transform.parent = _muscleCar.transform;

                // _muscleCarScript enabled is true
                _muscleCarScript.enabled = true;
                
                // _muscleCarCamera enabled is true
                _muscleCarCamera.enabled = true;

                // _muscleCarCameraAudioListener enabled is true
                _muscleCarCameraAudioListener.enabled = true; 

                // _inMuscleCar is true
                _inMuscleCar = true;

            } // close if not _inMuscleCar and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class MuscleCarEntry  

} // close namespace VehiclesControl
