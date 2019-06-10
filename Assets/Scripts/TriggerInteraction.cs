using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInteraction : MonoBehaviour
{
	public float value;
	public float speed = 1;

	private void OnTriggerEnter(Collider other)
	{
		LerpMaterialValue lerp = other.GetComponent<LerpMaterialValue>();
		if (lerp != null)
		{
			lerp.SetLerp(value, speed);
		}
	}
}
