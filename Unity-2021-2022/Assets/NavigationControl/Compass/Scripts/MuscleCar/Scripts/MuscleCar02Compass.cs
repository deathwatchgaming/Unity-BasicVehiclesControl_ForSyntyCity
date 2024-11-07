/*
*  Name: Muscle Car 02 Compass
*  File: MuscleCar02Compass.cs
*  Author: Deathwatch Gaming
*  License: MIT
*  Unity Version(s): Unity 2021+ - 2022+
*/

// using
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// namespace NavigationControl
namespace NavigationControl
{
	// public class MuscleCar02Compass
	public class MuscleCar02Compass : MonoBehaviour
	{
		// Header
		[Header("Raw Images")]

			// Tooltip
			[Tooltip("The compass background raw image")]
			// RawImage _compassForeground
			[SerializeField] private RawImage _compassForeground;

			// Tooltip
			[Tooltip("The compass foreground raw image")]
			// RawImage _compassForeground
			[SerializeField] private RawImage _compassBackground;	

		// Header
		[Header("Transform")]

			// Tooltip
			[Tooltip("The MuscleCar02 transform")]
			// Transform _muscleCar02
			[SerializeField] private Transform _muscleCar02;

		// Header
		[Header("Text")]

			// Tooltip
			[Tooltip("The compass direction text")]
			// TMP_Text _compassDirection
			[SerializeField] private TMP_Text _compassDirection;

		// Header
		[Header("Enabled State")]						

			// Tooltip
			[Tooltip("The compass enabled state")]
			// bool compassEnabled
			public bool compassEnabled = false;

		// MuscleCar02Compass _muscleCar02Compass
		public static MuscleCar02Compass _muscleCar02Compass;

		// private void Start
		private void Start()
		{
			// _muscleCar02Compass
			_muscleCar02Compass = this;

		} // close private void Start
		
		// private void Update
		private void Update()
		{
			// if compassEnabled is true
			if (compassEnabled == true)
			{
				// _compassDirection game object is active
				_compassDirection.gameObject.SetActive(true);

				// _compassBackground game object is active
				_compassBackground.gameObject.SetActive(true);

				// _compassForeground game object is active
				_compassForeground.gameObject.SetActive(true);

				// Get Component MuscleCar02Compass is enabled
				GetComponent<MuscleCar02Compass>().enabled = true;

				// Debug Log MuscleCar02 compass is enabled
				//Debug.Log("The MuscleCar02 compass is enabled");

			} // close if compassEnabled is true

			// else if compassEnabled is false
			else if (compassEnabled == false)
			{
				// Debug Log MuscleCar02 compass is disabled
				//Debug.Log("The MuscleCar02 compass is disabled");

				// _compassDirection game object is not active
				_compassDirection.gameObject.SetActive(false);

				// _compassBackground game object is not active
				_compassBackground.gameObject.SetActive(false);

				// _compassForeground game object is not active
				_compassForeground.gameObject.SetActive(false);

				// Get Component MuscleCar02Compass is not enabled
				GetComponent<MuscleCar02Compass>().enabled = false;

			} // close else if compassEnabled is false

			// Get a handle on the image's uvRect

			// _compassForeground uvRect is new Rect _muscleCar02 localEulerAngles.y 360, 0, 1, 1
			_compassForeground.uvRect = new Rect(_muscleCar02.localEulerAngles.y / 360, 0, 1, 1);

			// Get a copy of the _muscleCar02 forward vector

			// Vector3 forward is _muscleCar02 transform forward
			Vector3 forward = _muscleCar02.transform.forward;

			// Zero out the Y of _muscleCar02 forward vector to only get the direction in the X,Z 

			// forward y is 0
			forward.y = 0;

			// Clamp angles to 5 degree increments

			// float _headingAngle is Quaternion Look Rotation forward eulerAngles y
			float _headingAngle = Quaternion.LookRotation(forward).eulerAngles.y;

			//_headingAngle is 5 times Mathf RoundToInt _headingAngle divided by 5.0f
			_headingAngle = 5 * (Mathf.RoundToInt(_headingAngle / 5.0f));

			// Convert float to integer for switch statement

			// int _displayangle
			int _displayangle;

			// _displayangle is Mathf Round To Integer _headingAngle
			_displayangle = Mathf.RoundToInt(_headingAngle);

			// Set the compass degree text to the clamped value, 
			// but change it to the letter if it is a true direction

			// Switch _displayangle
			switch (_displayangle)
			{
				// Case is 0
				case 0:

					// Compass direction text is North
					_compassDirection.text = "N";

				// Case 0 break			
				break;

				// Case	is 360		
				case 360:

					// Compass direction text is North
					_compassDirection.text = "N";

				// Case 360 break			
				break;

				// Case	is 45		
				case 45:

					// Compass direction text is North East
					_compassDirection.text = "NE";

				// Case 45 break			
				break;

				// Case	is 90		
				case 90:

					// Compass direction text is East
					_compassDirection.text = "E";

				// Case 90 break			
				break;

				// Case	is 130		
				case 130:

					// Compass direction text is South East
					_compassDirection.text = "SE";

				// Case 130 break			
				break;

				// Case	is 180		
				case 180:

					// Compass direction text is South
					_compassDirection.text = "S";

				// Case 180 break			
				break;

				// Case	is 225		
				case 225:

					// Compass direction text is South West
					_compassDirection.text = "SW";

				// Case 225 break			
				break;

				// Case	is 270		
				case 270:

					// Compass direction text is West
					_compassDirection.text = "W";

				// Case 270 break			
				break;

				// Case is default			
				default:

					// Compass direction text is heading angle to string
					_compassDirection.text = _headingAngle.ToString();

				// Case default break
				break;

			} // Close Switch _displayangle

		} // close private void Update

	} // close public class MuscleCar02Compass

} // close namespace NavigationControl