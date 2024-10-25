using UnityEngine;
using System.Collections;

namespace TemporarilyResolve
{
	public class COGWheelColliderEnabler : MonoBehaviour
	{

		[Header("Wheel Colliders")]

			[Tooltip("Add just one of any of the wheel colliders")]
			[SerializeField] private WheelCollider _wheelCollider;

		[Header("COG Offset")]

			[Tooltip("Zero out the center of gravity offset in your controller first as this replaces such for now")]
			[SerializeField] private float _centreOfGravityOffset = -1f;

		Rigidbody _rigidbody;

		private void Awake()
		{
		    _rigidbody = GetComponent<Rigidbody>();

		    _wheelCollider.enabled = false;

		    float duration = 0.000001f;

		    StartCoroutine(EnableWheelCollider(duration));
		}

		private IEnumerator EnableWheelCollider(float duration)
		{
		    yield return new WaitForSeconds(duration);

		    // Adjust center of mass vertically, to help prevent the car from rolling
		    _rigidbody.centerOfMass += Vector3.up * _centreOfGravityOffset;

		    _wheelCollider.enabled = true;

		}
	}	
}