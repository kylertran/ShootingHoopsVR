using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
	public string nextScene;
	public Animator animator;
	
	public void LoadScene()
	{
		//animator.SetTrigger("FadeOut");
		Debug.Log("Scene Changed!");
		SceneManager.LoadScene(nextScene);
	}
}
