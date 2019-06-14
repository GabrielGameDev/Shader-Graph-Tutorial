using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VertexDisplacement : MonoBehaviour
{
	public float amount;
	public Light myLight;
	private MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
		meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

		amount = Mathf.Lerp(amount, 0, Time.deltaTime);
		meshRenderer.material.SetFloat("_amount", amount);

		myLight.range = amount * 6;
		myLight.intensity = amount * 24;
		

    }
}
