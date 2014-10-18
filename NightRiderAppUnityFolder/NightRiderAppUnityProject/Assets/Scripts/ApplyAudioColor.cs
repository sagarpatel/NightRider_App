using UnityEngine;
using System.Collections;

public class ApplyAudioColor : MonoBehaviour 
{
	AudioDirectorScript audioDirector;
	Material objectMaterial;

	public bool isParticles = false;

	ParticleSystem.Particle[] particlesArray;

	void Start () 
	{
		audioDirector = FindObjectOfType<AudioDirectorScript>().GetComponent<AudioDirectorScript>();

		if(isParticles == true)
		{
			particlesArray = new ParticleSystem.Particle[particleSystem.particleCount];
			particleSystem.GetParticles(particlesArray);
		}
	}


	void Update () 
	{
		if(isParticles == true)
		{
			particleSystem.GetParticles(particlesArray);
			for(int i  = 0; i < particlesArray.Length; i++)
			{
				particlesArray[i].color = audioDirector.calculatedRGB;
			}
			particleSystem.SetParticles(particlesArray,particlesArray.Length);
		}
		else
			renderer.material.color = audioDirector.calculatedRGB;
	}


}
