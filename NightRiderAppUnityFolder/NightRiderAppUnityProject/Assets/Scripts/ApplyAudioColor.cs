using UnityEngine;
using System.Collections;

public class ApplyAudioColor : MonoBehaviour 
{
	AudioDirectorScript audioDirector;
	Material objectMaterial;

	void Start () 
	{
		audioDirector = FindObjectOfType<AudioDirectorScript>().GetComponent<AudioDirectorScript>();
		objectMaterial = renderer.material;
	}


	void Update () 
	{
		objectMaterial.color = audioDirector.calculatedRGB;
	}


}
