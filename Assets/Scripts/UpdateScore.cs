using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
	public TextMesh Txt;
	int currentScore;
    
	// Start is called before the first frame update
	void Start()
	{
		currentScore = 0;
	}
	
	void OnTriggerEnter()
    {
        currentScore++;
		//Debug.Log("Score: " + currentScore);
		Txt.text = currentScore.ToString();
    }
}
