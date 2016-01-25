using UnityEngine;
using System.Collections;

public class RadomSpawning : MonoBehaviour
{
	public GameObject box;
	public GameObject box1;
	public GameObject box2;

	public Transform boxSpawn;

	//Starts the endless spawning
	void Start()
	{
		StartCoroutine (SpawnBoxes ());
	}
    
	IEnumerator SpawnBoxes()
    {
		//While true is always met so ensure continuous spawning
		while (true) 
		{
			//picks a random value between the two numbers to determine the box to spawn and how long it should wait before spawning another one
			int spawnChoise = Random.Range (1, 4);
			float spawnWait = Random.Range (1.5f, 3.5f);

			Debug.Log(spawnWait);

			//box one
			if (spawnChoise == 1) {
				Instantiate (box, boxSpawn.position, boxSpawn.rotation);
			}

			//box two
			if (spawnChoise == 2) {
				Instantiate (box1, boxSpawn.position, boxSpawn.rotation);
			}

			//box three
			if (spawnChoise == 3) {
				Instantiate (box2, boxSpawn.position, boxSpawn.rotation);
			}

			//waits with executing the code
			yield return new WaitForSeconds(spawnWait);
		}
    } 
}