/*
 * File: SedanLarge Entry
 * Name: SedanLargeEntry.cs
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

    // public class SedanLargeEntry 
    public class SedanLargeEntry : MonoBehaviour
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

            [Tooltip("The sedanLarge game object")]
            // GameObject _sedanLarge
            [SerializeField] private GameObject _sedanLarge;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inSedanLarge is false
            [SerializeField] private bool _inSedanLarge = false;
        
        // SedanLargeController _sedanLargeScript
        private SedanLargeController _sedanLargeScript;

        // Camera _sedanLargeCamera
        private Camera _sedanLargeCamera;

        // AudioListener _sedanLargeCameraAudioListener
        private AudioListener _sedanLargeCameraAudioListener; 

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
            // _sedanLargeScript is GetComponent SedanLargeController
            _sedanLargeScript = GetComponent<SedanLargeController>();

            // _sedanLargeScript enabled is false
            _sedanLargeScript.enabled = false;
            
            // _sedanLargeScript is GetComponentInChildren
            _sedanLargeCamera = GetComponentInChildren<Camera>();

            // _sedanLargeCamera enabled is false
            _sedanLargeCamera.enabled = false;

            // _sedanLargeCameraAudioListener is GetComponentInChildren AudioListener
            _sedanLargeCameraAudioListener = GetComponentInChildren<AudioListener>();
            
            // _sedanLargeCameraAudioListener enabled is false
            _sedanLargeCameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName SedanLarge_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("SedanLarge_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inSedanLarge and Input GetKey KeyCode _exitKey
            if (_inSedanLarge && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _sedanLargeScript enabled is false
                _sedanLargeScript.enabled = false;
                
                // _sedanLargeCamera enabled is false
                _sedanLargeCamera.enabled = false;

                // _sedanLargeCameraAudioListener enabled is false
                _sedanLargeCameraAudioListener.enabled = false; 

                // _inSedanLarge is false
                _inSedanLarge = false;

            } // close if _inSedanLarge and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inSedanLarge and gameObject tag is Player
            if (!_inSedanLarge && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inSedanLarge and gameObject tag is Player
            
            // if not _inSedanLarge and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inSedanLarge && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _sedanLarge transform
                _player.transform.parent = _sedanLarge.transform;

                // _sedanLargeScript enabled is true
                _sedanLargeScript.enabled = true;
                
                // _sedanLargeCamera enabled is true
                _sedanLargeCamera.enabled = true;

                // _sedanLargeCameraAudioListener enabled is true
                _sedanLargeCameraAudioListener.enabled = true; 

                // _inSedanLarge is true
                _inSedanLarge = true;

            } // close if not _inSedanLarge and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class SedanLargeEntry  

} // close namespace VehiclesControl
