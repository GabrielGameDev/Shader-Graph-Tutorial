using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
	private Animator anim;

	private VertexDisplacement sphere;

	private void Awake()
	{
		anim = GetComponent<Animator>();
	}

	// Start is called before the first frame update
	void Start()
    {
		sphere = FindObjectOfType<VertexDisplacement>();
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetButtonDown("Jump"))
		{
			anim.SetTrigger("Attack");
		}   
    }

	
	public void AttackSphere(float value)
	{
		sphere.amount = value;
	}

}
