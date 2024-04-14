using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
	public AudioSource Score;
	public ParticleSystem particles;
	
    // Start is called before the first frame update
	void Start()
	{
		particles.Stop();
	}
	
    IEnumerator OnTriggerEnter()
    {
        Score.Play();
		
		particles.Play();
		yield return new WaitForSeconds(2);
		particles.Stop();
    }
}
