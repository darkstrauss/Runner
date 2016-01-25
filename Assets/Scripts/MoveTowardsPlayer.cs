using UnityEngine;
using System.Collections;

public class MoveTowardsPlayer : MonoBehaviour {

	float SCROLLSPEED = -5.0f;
	int multiply = 0;

	// Use this for initialization
	void Start () 
	{
		//set a destroy timer for 10 seconds
		Destroy (gameObject, 10);
	}
	
	// Update is called once per frame
	void Update ()
	{
		//after 20 seconds the game speeds up
		if (Time.time > 20 && multiply == 0) 
		{
			SCROLLSPEED = SCROLLSPEED * 2f;

			//this is used to ensure that it only executes once
			multiply++;
		}

        gameObject.transform.Translate(SCROLLSPEED * Time.deltaTime, 0, 0);
	}

	//when the player collides with the obstacle they are both destroyed
    void OnTriggerEnter(Collider box)
    {
        Debug.Log("Just Hit");

		Destroy (gameObject);
		Destroy (box.gameObject);
    }
}
