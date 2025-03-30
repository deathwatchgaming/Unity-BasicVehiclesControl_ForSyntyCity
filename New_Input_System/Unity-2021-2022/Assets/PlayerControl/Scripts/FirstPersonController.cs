/*
 * Name: FirstPersonController
 * File: FirstPersonController.cs
 * Author(s): DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 2021+ - 2022+
*/

// Player Transform Position: X: 0 Y: 0.9799998 Z: 0 / Tag: Player
// Player Camera Transform Position: X: 0 Y: 0.6 Z: 0  / Tag: MainCamera

// using
using UnityEngine;

// namespace PlayerControl
namespace PlayerControl
{
	// RequireComponent typeof CharacterController
	[RequireComponent(typeof(CharacterController))]

	// RequireComponent typeof AudioSource
	[RequireComponent(typeof(AudioSource))]

	// public class FirstPersonController
	public class FirstPersonController : MonoBehaviour 
	{
		// Movement Speeds
		[Header("Movement Speeds")]

			[Tooltip("The walk speed amount")]
			// float _walkSpeed is 3.0
			[SerializeField] private float _walkSpeed = 3.0f;

			[Tooltip("The sprint multiplier amount")]
			// float _sprintMultiplier is 2.0
			[SerializeField] private float _sprintMultiplier = 2.0f;

		// Jump Parameters
		[Header("Jump Parameters")]

			[Tooltip("The jump force amount")]
			// float _jumpForce is 5.0
			[SerializeField] private float _jumpForce = 5.0f;
            
			[Tooltip("The gravity amount")]
			// float _gravity is 9.81
			[SerializeField] private float _gravity = 9.81f;

		// Look Sensitivity
		[Header("Look Sensitivity")]
	        
			[Tooltip("The mouse sensitivity amount")]
			// float _mouseSensitivity is 2.0
			[SerializeField] private float _mouseSensitivity = 2.0f;
            
			[Tooltip("The up down range amount")]
			// float _upDownRange is 80.0
			[SerializeField] private float _upDownRange = 80.0f;
	    
		// Input Customizations
		[Header("Input Customizations")]
            
			[Tooltip("The vertical movement string")]
			// string _verticalMoveInput is Vertical
			[SerializeField] private string _verticalMoveInput = "Vertical";	
            
			[Tooltip("The horizontal movement string")]
			// string _horizontalMoveInput is Horizontal
			[SerializeField] private string _horizontalMoveInput = "Horizontal";	
            
			[Tooltip("The mouse y input string")]            
			// string _mouseYInput is Mouse Y
			[SerializeField] private string _mouseYInput = "Mouse Y";
            
			[Tooltip("The mouse x input string")]
			// string _mouseXInput is Mouse X
			[SerializeField] private string _mouseXInput = "Mouse X";
            
			[Tooltip("The sprint input keycode key")]
			// KeyCode _sprintKey is KeyCode LeftShift
			[SerializeField] private KeyCode _sprintKey = KeyCode.LeftShift;
            
			[Tooltip("The jump input keycode key")]
			// KeyCode _jumpKey is KeyCode Space
			[SerializeField] private KeyCode _jumpKey = KeyCode.Space;

		// Footstep Sounds
		[Header("Footstep Sounds")]
            
			[Tooltip("The footstep sounds audio source")]
			// AudioSource _footstepSource
			[SerializeField] private AudioSource _footstepSource;
            
			[Tooltip("The footstep sounds audio clip")]
			// Audioclip[] _footstepSounds
			[SerializeField] private AudioClip[] _footstepSounds;
            
			[Tooltip("The walk step interval amount")]
			// float _walkStepInterval is 0.5
			[SerializeField] private float _walkStepInterval = 0.5f;
            
			[Tooltip("The sprint step interval amount")]
			// float _sprintStepInterval is 0.3
			[SerializeField] private float _sprintStepInterval = 0.3f;
            
			[Tooltip("The velocity threshold amount")]
			// float _velocityThreshold is 2.0
			[SerializeField] private float _velocityThreshold = 2.0f;

			// float _nextStepTime
			private float _nextStepTime;

			// int _lastPlayedIndex is -1
			private int _lastPlayedIndex = -1;

			// bool _isMoving
			private bool _isMoving;	

			// Camera _mainCamera
			private Camera _mainCamera;

			// float _verticalRotation
			private float _verticalRotation;

			// Vector3 _currentMovement is Vector3 zero
			private Vector3 _currentMovement = Vector3.zero;

			// CharacterController _characterController
			private CharacterController _characterController;

		// private void Start
		private void Start()
		{
			// _characterController is GetComponent CharacterController
			_characterController = GetComponent<CharacterController>();

			// _footstepSource is GetComponent AudioSource
			_footstepSource = GetComponent<AudioSource>();

			// _mainCamera is Camera main
			_mainCamera = Camera.main;

			// Cursor lockState is CursorLockMode Locked
			Cursor.lockState = CursorLockMode.Locked;

			// Cursor visible is false
			Cursor.visible = false;

		} // close private void Start

		// private void Update
		private void Update()
		{
			// Handle Movement
			HandleMovement();

			// Handle Rotation
			HandleRotation();

			// Handle Footsteps
			HandleFootsteps();		

		} // close private void Update
	    
		// private void HandleMovement
		private void HandleMovement()
		{
			// float _verticalInput is Input GetAxis _verticalMoveInput
			float _verticalInput = Input.GetAxis(_verticalMoveInput);

			// float _horizontalInput is Input GetAxis _horizontalMoveInput
			float _horizontalInput = Input.GetAxis(_horizontalMoveInput);

			// float _speedMultiplier is Input GetKey _sprintKey ? _sprintMultiplier : 1f
			float _speedMultiplier = Input.GetKey(_sprintKey) ? _sprintMultiplier : 1f;

			// float _verticalSpeed is _verticalInput times _walkSpeed times _speedMultiplier
			float _verticalSpeed = _verticalInput * _walkSpeed * _speedMultiplier;

			// float _horizontalSpeed is _horizontalInput times _walkSpeed times _speedMultiplier
			float _horizontalSpeed = _horizontalInput * _walkSpeed * _speedMultiplier;		

			// Vector3 _horizontalMovement is Vector3 _horizontalSpeed 0 _verticalSpeed
			Vector3 _horizontalMovement = new Vector3 (_horizontalSpeed, 0, _verticalSpeed);

			// _horizontalMovement is transform rotation times _horizontalMovement
			_horizontalMovement = transform.rotation * _horizontalMovement;

			// Handle Gravity And Jumping
			HandleGravityAndJumping();

			// _currentMovement x is _horizontalMovement x
			_currentMovement.x = _horizontalMovement.x;

			// _currentMovement z is _horizontalMovement z
			_currentMovement.z = _horizontalMovement.z;

			// _characterController Move _currentMovement times Time deltaTime
			_characterController.Move(_currentMovement * Time.deltaTime);

			// _isMoving is _verticalInput not 0 or _horizontalInput not 0
			_isMoving = _verticalInput != 0 || _horizontalInput != 0; // inputs vertical & horizontal

		} // close private void HandleMovement
	    
		// private void HandleGravityAndJumping
		private void HandleGravityAndJumping()
		{	        
			// if _characterController isGrounded
			if (_characterController.isGrounded)
			{
				// _currentMovement y is -0.5
				_currentMovement.y = -0.5f;

				// if Input GetKeyDown jumpKey
				if (Input.GetKeyDown(_jumpKey))
				{
					// _currentMovement y is _jumpForce
					_currentMovement.y = _jumpForce;

				} // close if Input GetKeyDown _jumpKey

			} // close if _characterController isGrounded
	        
			// else
			else 
			{
				// _currentMovement y _gravity times Time deltaTime
				_currentMovement.y -= _gravity * Time.deltaTime;

			} // close else

		} // close void HandleGravityAndJumping

		// private void HandleRotation
		private void HandleRotation()
		{
			// _mouseXRotation is Input GetAxis _mouseXInput times _mouseSensitivity
			float _mouseXRotation = Input.GetAxis(_mouseXInput) * _mouseSensitivity;

			// transform Rotate 0 _mouseXRotation 0
			transform.Rotate(0, _mouseXRotation, 0);

			// _verticalRotation Input GetAxis _mouseYInput times _mouseSensitivity
			_verticalRotation -= Input.GetAxis(_mouseYInput) * _mouseSensitivity;

			// _verticalRotation is Mathf Clamp _verticalRotation -_upDownRange _upDownRange
			_verticalRotation = Mathf.Clamp(_verticalRotation, -_upDownRange, _upDownRange);

			// _mainCamera transform localRotation is Quaternion Euler _verticalRotation 0 0
			_mainCamera.transform.localRotation = Quaternion.Euler(_verticalRotation, 0, 0);

		} // close private void HandleRotation

		// private void HandleFootsteps
		private void HandleFootsteps()
		{
			// float _currentStepInterval is Input GetKey _sprintKey ? _sprintStepInterval : _walkStepInterval
			float _currentStepInterval = (Input.GetKey(_sprintKey) ? _sprintStepInterval : _walkStepInterval);

			// if _characterController isGrounded and _isMoving and Time time > _nextStepTime and_characterController velocity magnitude > _velocityThreshold
			if (_characterController.isGrounded && _isMoving && Time.time > _nextStepTime && _characterController.velocity.magnitude > _velocityThreshold)
			{
				// Play Footstep Sounds
				PlayFootstepSounds();
	            
				// _nextStepTime is Time time plus _currentStepInterval
				_nextStepTime = Time.time + _currentStepInterval;

			} // close if _characterController isGrounded and _isMoving and Time time > _nextStepTime and_characterController velocity magnitude > _velocityThreshold
	       
		} // close private void HandleFootsteps

		// private void PlayFootstepsounds
		private void PlayFootstepSounds()
		{
			// int _randomIndex
			int _randomIndex;

			// if _footstepSounds Length 1
			if (_footstepSounds.Length == 1)
			{
				// _randomIndex is 0
				_randomIndex = 0;

			} // close if _footstepSounds Length 1

			// else
			else
			{
				// _randomIndex Random Range 0 _footstepSounds.Length - 1
				_randomIndex = Random.Range(0, _footstepSounds.Length - 1);

				// if _randomIndex >= _lastPlayedIndex
				if (_randomIndex >= _lastPlayedIndex)
				{
					// _randomIndex
					_randomIndex++;

				} // close if _randomIndex >= _lastPlayedIndex

			} // close else

			// _lastPlayedIndex is _randomIndex
			_lastPlayedIndex = _randomIndex;

			// _footsepSource clip is _footstepSounds[] _randomIndex
			_footstepSource.clip = _footstepSounds[_randomIndex];
	        
			// _footsepSource Play
			_footstepSource.Play();

		} // close private void PlayFootstepsounds

	} // close public class FirstPersonController

} // close namespace PlayerControl
