/*
 * Name: FirstPersonController (New Input System)
 * File: FirstPersonController.cs
 * Author(s): DeathwatchGaming
 * License: MIT
*/

// Player Transform Position: X: 0 Y: 0.9799998 Z: 0 / Tag: Player
// Player Camera Transform Position: X: 0 Y: 0.6 Z: 0  / Tag: MainCamera

// using
using UnityEngine;
using UnityEngine.InputSystem;

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

		// Footstep Sounds
		[Header("Footstep Sounds")]

			[Tooltip("The footstep sounds audio source")]
			// AudioSource _footstepSource
			[SerializeField] private AudioSource _footstepSource;

			[Tooltip("The footstep sounds audio clip")]
			// AudioClip[] _footstepSounds
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

		// Input Actionss
		[Header("Input Actions")]

			[Tooltip("The input action asset")]
			// InputActionAsset _playerControls
			[SerializeField] private InputActionAsset _playerControls;

		// int _lastPlayedIndexis -1
		private int _lastPlayedIndex = -1;

		// bool _isMoving
		private bool _isMoving;

		// float _nextStepTime
		private float _nextStepTime;

		// Camera _mainCamera
		private Camera _mainCamera;

		// float _verticalRotation
		private float _verticalRotation;

		// Vector3 _currentMovementis Vector3 zero
		private Vector3 _currentMovement = Vector3.zero;

		// CharacterController _characterController
		private CharacterController _characterController;

		// InputAction _moveAction
		private InputAction _moveAction;

		// InputAction _lookAction
		private InputAction _lookAction;

		// InputAction _jumpAction
		private InputAction _jumpAction;

		// InputAction _sprintAction
		private InputAction _sprintAction;

		// Vector2 _moveInput
		private Vector2 _moveInput;

		// Vector2 _lookInput
		private Vector2 _lookInput;

		// private void Awake
		private void Awake()
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

			// _moveAction
			_moveAction = _playerControls.FindActionMap("Player").FindAction("Move");

			// _lookAction
			_lookAction = _playerControls.FindActionMap("Player").FindAction("Look");

			// _jumpAction
			_jumpAction = _playerControls.FindActionMap("Player").FindAction("Jump");

			// _sprintAction
			_sprintAction = _playerControls.FindActionMap("Player").FindAction("Sprint");

			// _moveAction performed
			_moveAction.performed += context => _moveInput = context.ReadValue<Vector2>();

			// _moveAction canceled
			_moveAction.canceled += context => _moveInput = Vector2.zero;

			// _lookAction performed
			_lookAction.performed += context => _lookInput = context.ReadValue<Vector2>();

			// _lookAction canceled
			_lookAction.canceled += context => _lookInput = Vector2.zero;
			
		} // close private void Awake

		// private void OnEnable
		private void OnEnable()
		{
			// _moveAction Enable
			_moveAction.Enable();

			// _lookAction Enable
			_lookAction.Enable();

			// _jumpAction Enable
			_jumpAction.Enable();

			// _sprintAction Enable		
			_sprintAction.Enable();

		} // close private void OnEnable

		// private void OnDisable
		private void OnDisable()
		{
			// _moveAction Disable
			_moveAction.Disable();

			// _lookAction Disable
			_lookAction.Disable();

			// _jumpAction Disable
			_jumpAction.Disable();

			// _sprintAction Disable		
			_sprintAction.Disable();

		} // close private void OnDisable

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
			// float _speedMultiplier 
			float _speedMultiplier = _sprintAction.ReadValue<float>() > 0 ? _sprintMultiplier : 1f;

			// float _verticalSpeed is _moveInput y times _walkSpeed times _speedMultiplier
			float _verticalSpeed = _moveInput.y * _walkSpeed * _speedMultiplier;

			// float _horizontalSpeed is _moveInput x times _walkSpeed times _speedMultiplier
			float _horizontalSpeed = _moveInput.x * _walkSpeed * _speedMultiplier;

			// Vector3 _horizontalMovement
			Vector3 _horizontalMovement = new Vector3(_horizontalSpeed, 0, _verticalSpeed);

			// _horizontalMovement is transform rotation times _horizontalMovement
			_horizontalMovement = transform.rotation * _horizontalMovement;

			// Handle Gravity And Jumping
			HandleGravityAndJumping();

			// _currentMovement x is _horizontalMovement x
			_currentMovement.x = _horizontalMovement.x;

			// _currentMovement z is  _horizontalMovement z
			_currentMovement.z = _horizontalMovement.z;

			// _characterController Move
			_characterController.Move(_currentMovement * Time.deltaTime);

			// _isMoving is _moveInput y not equals 0 and or _moveInput x not equals 0
			_isMoving = _moveInput.y != 0 || _moveInput.x != 0;

		} // close private void HandleMovement

		// private void HandleGravityAndJumping
		private void HandleGravityAndJumping()
		{
			// if _characterController isGrounded
			if (_characterController.isGrounded)
			{
				// _currentMovement y is  -0.5f
				_currentMovement.y = -0.5f;

				// if _jumpAction triggered
				if (_jumpAction.triggered)
				{
					// _currentMovement y is  _jumpForce
					_currentMovement.y = _jumpForce;

				} // close if _jumpAction triggered

			} // close if _characterController isGrounded

			// else
			else
			{
				// _currentMovement y minus equals _gravity times Time deltaTime
				_currentMovement.y -= _gravity * Time.deltaTime;

			} // close else

		} // close private void HandleGravityAndJumping	

		// private void HandleRotation
		private void HandleRotation()
		{
			// float _mouseXRotation is _lookInput x times _mouseSensitivity
			float _mouseXRotation = _lookInput.x * _mouseSensitivity;

			// transform Rotate 0, _mouseXRotation, 0
			transform.Rotate(0, _mouseXRotation, 0);

			// _verticalRotation minus equals _lookInput y times _mouseSensitivity
			_verticalRotation -= _lookInput.y * _mouseSensitivity;

			// _verticalRotation is Mathf Clamp _verticalRotation, minus _upDownRange, _upDownRange
			_verticalRotation = Mathf.Clamp(_verticalRotation, -_upDownRange, _upDownRange);

			// _mainCamera transform localRotation is Quaternion Euler _verticalRotation, 0, 0
			_mainCamera.transform.localRotation = Quaternion.Euler(_verticalRotation, 0, 0);

		}  // close private void HandleRotation

		// private void HandleFootsteps
		private void HandleFootsteps()
		{
			// float currentStepInterval
			float currentStepInterval = (_sprintAction.ReadValue<float>() > 0 ? _sprintStepInterval : _walkStepInterval);

			// if _characterController isGrounded & _isMoving & Time time > _nextStepTime &  _characterController velocity magnitude > _velocityThreshold
			if (_characterController.isGrounded && _isMoving && Time.time > _nextStepTime && _characterController.velocity.magnitude > _velocityThreshold)
			{
				// Play Footstep Sounds
				PlayFootstepSounds();

				// _nextStepTime is Time time plus currentStepInterval
				_nextStepTime = Time.time + currentStepInterval;

			}  // close if _characterController isGrounded & _isMoving & Time time > _nextStepTime &  _characterController velocity magnitude > _velocityThreshold

		} // close private void HandleFootsteps

		// private void PlayFootstepSounds
		private void PlayFootstepSounds()
		{
			// int _randomIndex
			int _randomIndex;

			// if _footstepSounds Length == 1
			if (_footstepSounds.Length == 1)
			{
				// _randomIndex is 0
				_randomIndex = 0;

			} // close if _footstepSounds Length == 1

			// else
			else
			{
				// _randomIndex is Random Range 0, _footstepSounds.Length - 1
				_randomIndex = Random.Range(0, _footstepSounds.Length - 1);

				// if _randomIndex >= _lastPlayedIndex
				if (_randomIndex >= _lastPlayedIndex)
				{
					// _randomIndex plus
					_randomIndex++;

				} // close if _randomIndex >= _lastPlayedIndex

			} // close else

			// _lastPlayedIndex is _randomIndex 
			_lastPlayedIndex = _randomIndex;

			// _footstepSource clip is _footstepSounds[_randomIndex]
			_footstepSource.clip = _footstepSounds[_randomIndex];

			// _footstepSource Play
			_footstepSource.Play();

		} // close private void PlayFootstepSounds	

	} // close public class FirstPersonController

} // close namespace PlayerControl
