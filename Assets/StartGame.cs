using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
	public AudioSource Music;
	public TextMesh Text3;
	public TextMesh Text2;
	public TextMesh Text1;
	public TextMesh Timer;
	public GameObject Barrier;
	
	bool timerRunning = false;
	public float timeRemaining = 60;
	string timeText;
	
    // Start is called before the first frame update
    IEnumerator Start()
    {
		Music.Play();
		Text3.GetComponent<MeshRenderer>().enabled = true;
        yield return new WaitForSeconds(2);
		Text3.GetComponent<MeshRenderer>().enabled = false;
		Text2.GetComponent<MeshRenderer>().enabled = true;
		yield return new WaitForSeconds(2);
		Text2.GetComponent<MeshRenderer>().enabled = false;
		Text1.GetComponent<MeshRenderer>().enabled = true;
		yield return new WaitForSeconds(2);
		Text1.GetComponent<MeshRenderer>().enabled = false;
		Destroy(Barrier);
		
		Timer.text = "60:00";
		timerRunning = true;
    }
	
	void Update()
	{
		if(timerRunning == true)
		{
			if (timeRemaining > 0)
			{
				Text1.GetComponent<MeshRenderer>().enabled = false;
				timeRemaining -= Time.deltaTime;
				timeText = timeRemaining.ToString();
				timeText = timeText.Replace(".", ":");
				timeText = timeText.Substring(0,5);
				Timer.text = timeText;
				
				if (timeRemaining <= 3 && timeRemaining > 2)
				{
					Text3.GetComponent<MeshRenderer>().enabled = true;
				}
				if (timeRemaining <= 2 && timeRemaining > 1)
				{
					Text3.GetComponent<MeshRenderer>().enabled = false;
					Text2.GetComponent<MeshRenderer>().enabled = true;
				}
				if (timeRemaining <= 1 && timeRemaining > 0)
				{
					Text2.GetComponent<MeshRenderer>().enabled = false;
					Text1.GetComponent<MeshRenderer>().enabled = true;
				}
			}
			else
			{
				Timer.text = "00:00";
				timerRunning = false;
			}
		}
	}
}
