using UnityEngine;
using System.Collections;

public class Audiodirector : MonoBehaviour 
{

	public AudioSource audioSource;

	void Start () 
	{
		audioSource.Play();
		audioSource.loop = true;
	}



	void Update () 
	{

	
	}
}
