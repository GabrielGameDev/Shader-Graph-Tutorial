using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMaterialValue : MonoBehaviour
{

	public string property = "_DissolveValue";

	private Renderer meshRenderer;

	private float value;

	private float desiredValue = 0;

	private bool canLerp;

	private float speed;

	private void Awake()
	{
		meshRenderer = GetComponentInChildren<Renderer>();
	}

	void Update()
	{

		if (!canLerp)
			return;

		value = Mathf.Lerp(value, desiredValue, Time.deltaTime * speed);
		meshRenderer.material.SetFloat(property, value);

	}

	public void SetLerp(float newValue, float newSpeed)
	{
		value = meshRenderer.material.GetFloat(property);
		speed = newSpeed;
		desiredValue = newValue;
		canLerp = true;

	}
}
