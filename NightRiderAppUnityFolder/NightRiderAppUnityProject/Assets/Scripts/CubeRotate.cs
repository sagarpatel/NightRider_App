using UnityEngine;
using System.Collections;

public class CubeRotate : MonoBehaviour 
{

	public float rotationSpeed = 10.0f;


	void Start () 
	{
	
	}


	void Update () 
	{
		float rot = rotationSpeed * Time.deltaTime;
		transform.Rotate(new Vector3(rot, 0, rot),Space.Self);
	}
}
