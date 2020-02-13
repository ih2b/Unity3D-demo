using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
	private GameObject sphere;
	// Use this for initialization
	void Start ()
	{
		sphere =GameObject.Find("Sphere");
	}
	
	// Update is called once per frame
	void Update () {
		sphere.transform.Translate(1,0,0);
	}
}
