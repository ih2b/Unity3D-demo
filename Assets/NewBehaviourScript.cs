using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	private string moveInputAxis = "Vertical";
	private string turnInputAxis = "Horizontal";
	public float rotationRate = 360;
	public float moveSpeed = 2;
	
	// Update is called once per frame
	void Update ()
	{
		float moveAxis = Input.GetAxis(moveInputAxis);
		float turnAxis = Input.GetAxis(turnInputAxis);
	}
private  void ApplyInput(float)
	private void Move(float input)
	{
		
	}
	private void Turn(float input)
	{
		
	}
}
