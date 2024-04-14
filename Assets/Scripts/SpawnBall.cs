using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
	public Transform Spawnpoint;
	public GameObject Prefab;
	
    // Start is called before the first frame update
    public void OnDrop()
    {
		Debug.Log("Spawned ball");
		Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation); 
    }
}
