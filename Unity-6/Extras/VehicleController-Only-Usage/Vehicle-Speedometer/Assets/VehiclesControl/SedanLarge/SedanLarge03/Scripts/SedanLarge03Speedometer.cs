/*
 * File: SedanLarge 03 Speedometer
 * Name: SedanLarge03Speedometer.cs
 * Author: DeathwatchGaming
 * License: MIT
 */

// using
using TMPro;
using System;
using UnityEngine;
using UnityEngine.UI;

// namespace VehiclesControl
namespace VehiclesControl
{
    // public enum SedanLarge03SpeedUnit
	public enum SedanLarge03SpeedUnit
	{
		mph,
		kmh	

	} // close public enum SedanLarge03SpeedUnit

	// public class SedanLarge03Speedometer 
	public class SedanLarge03Speedometer : MonoBehaviour
	{
		// Speedometer
		[Header("Speedometer")]

			[Tooltip("The speedometer needle")]
			// GameObject _needle
			[SerializeField] private GameObject _needle;

			[Tooltip("The start position")]
			// float _startPosition
			[SerializeField] private float _startPosition = 220f;

			[Tooltip("The end position")]
			// float _endPosition
			[SerializeField] private float _endPosition = -41f;

			[Tooltip("The desired position")]
			// float _desiredPosition
			[SerializeField] private float _desiredPosition;

			[Tooltip("The vehicle speed")]
			// float _vehicleSpeed
			[SerializeField] private float _vehicleSpeed = 0f;

 		// Speed Text       
		[Header("Speed Text")]

			[Tooltip("The decimal places")]
			// int _decimalPlaces 
			[SerializeField] private int _decimalPlaces = 0;

			[Tooltip("The previous text string")]
			//  string _previousText		
			[SerializeField] private string _previousText;

			[Tooltip("The speed measurement unit")]
			// SedanLarge03SpeedUnit _speedUnit	
			[SerializeField] private SedanLarge03SpeedUnit _speedUnit;

			[Tooltip("The interface speed amount text")]
			// TMP_Text speedText
			[SerializeField] private TMP_Text _speedText;

		// float _currentSpeed
		float _currentSpeed;

		// SedanLarge03Controller _sedanLarge03Script
		private SedanLarge03Controller _sedanLarge03Script;

		// Rigidbody _rigidbody
		private Rigidbody _rigidbody;

		// private void Start
		private void Start()
		{
			// _sedanLarge03Script is GetComponent SedanLarge03Controller
			_sedanLarge03Script = GetComponent<SedanLarge03Controller>();

			// _rigidbody
			_rigidbody = GetComponent<Rigidbody>();	

		} // close private void Start

		// private void Update
		private void Update()
		{
			// if _speedUnit equals SedanLarge03SpeedUnit.mph
			if (_speedUnit == SedanLarge03SpeedUnit.mph)
			{
				// 2.23694 is the constant to convert a value from m/s to mph

				// _currentSpeed
				_currentSpeed = (float)Math.Round(_rigidbody.linearVelocity.magnitude * 2.23694f, _decimalPlaces);

				// _speedText.text
				_speedText.text = _previousText + _currentSpeed.ToString() + " mph";

			} // close if _speedUnit equals SedanLarge03SpeedUnit.mph

			// else 
			else 
			{
				// 3.6 is the constant to convert a value from m/s to km/h

				// _currentSpeed
				_currentSpeed = (float)Math.Round(_rigidbody.linearVelocity.magnitude * 3.6f, _decimalPlaces);

				// _speedText.text
				_speedText.text = _previousText + _currentSpeed.ToString() + " km/h";

			} // close else

		} // close private void Update

		// private void FixedUpdate
		private void FixedUpdate()
		{
			// _vehicleSpeed
			_vehicleSpeed = _currentSpeed;

			// UpdateSpeedoNeedle
			UpdateSpeedoNeedle();

		} // close private void FixedUpdate

		// private void UpdateSpeedoNeedle
		private void UpdateSpeedoNeedle()
		{
			// _desiredPosition
			_desiredPosition = _startPosition - _endPosition;

			// float _temp 
			float _temp = _vehicleSpeed / 180;

			// _needle.transform.eulerAngles
			_needle.transform.eulerAngles = new Vector3(0, 0, (_startPosition -_temp * _desiredPosition));

		} // close private void UpdateSpeedoNeedle				

	} // close public class SedanLarge03Speedometer

} // close namespace VehiclesControl
