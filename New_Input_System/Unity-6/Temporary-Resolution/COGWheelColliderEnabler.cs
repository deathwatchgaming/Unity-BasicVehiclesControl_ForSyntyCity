/*
 * Name: Temporarily Resolve COG & WC Unity 6 Bug
 * File: COGWheelColliderEnabler.cs
 * Author: DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 6+ 
*/

// using
using UnityEngine;
using System.Collections;

// namespace TemporarilyResolve
namespace TemporarilyResolve
{
	// public class COGWheelColliderEnabler
	public class COGWheelColliderEnabler : MonoBehaviour
	{
		// Header
		[Header("Wheel Colliders")]

			// Tooltip
			[Tooltip("Add just one of any of the wheel colliders")]
			// WheelCollider _wheelCollider
			[SerializeField] private WheelCollider _wheelCollider;

		// Header
		[Header("COG Offset")]

			// Tooltip
			[Tooltip("Zero out the center of gravity offset in your controller first as this replaces such for now")]
			// float _centreOfGravityOffset is -1
			[SerializeField] private float _centreOfGravityOffset = -1f;

		// _rigidbody
		Rigidbody _rigidbody;

		// private void Awake
		private void Awake()
		{
			// _rigidbody is GetComponent Rigidbody
		    _rigidbody = GetComponent<Rigidbody>();

		    // _wheelCollider is not enabled
		    _wheelCollider.enabled = false;

		    // float duration is 0.000001
		    float duration = 0.000001f;

		    // Start Coroutine EnableWheelCollider duration
		    StartCoroutine(EnableWheelCollider(duration));

		} // close private void Awake

		// private IEnumerator EnableWheelCollider float duration
		private IEnumerator EnableWheelCollider(float duration)
		{
			// return WaitForSeconds duration
		    yield return new WaitForSeconds(duration);

		    // Adjust center of mass vertically, to help prevent the car from rolling
		    // _rigidbody centerOfMass
		    _rigidbody.centerOfMass += Vector3.up * _centreOfGravityOffset;

		    // _wheelCollider is enabled
		    _wheelCollider.enabled = true;

		} // close private IEnumerator EnableWheelCollider float duration

	} // close public class COGWheelColliderEnabler	

} // close namespace TemporarilyResolve
