/*
 * File: MuscleCar 04 Entry
 * Name: MuscleCar04Entry.cs
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

    // public class MuscleCar04Entry 
    public class MuscleCar04Entry : MonoBehaviour
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

            [Tooltip("The muscleCar04 game object")]
            // GameObject _muscleCar04
            [SerializeField] private GameObject _muscleCar04;

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
            // bool _inMuscleCar04 is false
            [SerializeField] private bool _inMuscleCar04 = false;
        
        // MuscleCar04Controller _muscleCar04Script
        private MuscleCar04Controller _muscleCar04Script;

        // Camera _muscleCar04Camera
        private Camera _muscleCar04Camera;

        // AudioListener _muscleCar04CameraAudioListener
        private AudioListener _muscleCar04CameraAudioListener; 

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
            // _muscleCar04Script is GetComponent MuscleCar04Controller
            _muscleCar04Script = GetComponent<MuscleCar04Controller>();

            // _muscleCar04Script enabled is false
            _muscleCar04Script.enabled = false;
            
            // _muscleCar04Script is GetComponentInChildren
            _muscleCar04Camera = GetComponentInChildren<Camera>();

            // _muscleCar04Camera enabled is false
            _muscleCar04Camera.enabled = false;

            // _muscleCar04CameraAudioListener is GetComponentInChildren AudioListener
            _muscleCar04CameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _muscleCar04CameraAudioListener enabled is false
            _muscleCar04CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName MuscleCar04_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("MuscleCar04_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inMuscleCar04 and Input GetKey KeyCode _exitKey
            if (_inMuscleCar04 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _muscleCar04Script enabled is false
                _muscleCar04Script.enabled = false;
                
                // _muscleCar04Camera enabled is false
                _muscleCar04Camera.enabled = false;

                // _muscleCar04CameraAudioListener enabled is false
                _muscleCar04CameraAudioListener.enabled = false; 

                // _inMuscleCar04 is false
                _inMuscleCar04 = false;

            } // close if _inMuscleCar04 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inMuscleCar04 and gameObject tag is Player
            if (!_inMuscleCar04 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inMuscleCar04 and gameObject tag is Player
            
            // if not _inMuscleCar04 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inMuscleCar04 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _muscleCar04 transform
                _player.transform.parent = _muscleCar04.transform;

                // _muscleCar04Script enabled is true
                _muscleCar04Script.enabled = true;
                
                // _muscleCar04Camera enabled is true
                _muscleCar04Camera.enabled = true;

                // _muscleCar04CameraAudioListener enabled is true
                _muscleCar04CameraAudioListener.enabled = true; 

                // _inMuscleCar04 is true
                _inMuscleCar04 = true;

            } // close if not _inMuscleCar04 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class MuscleCar04Entry  

} // close namespace VehiclesControl
