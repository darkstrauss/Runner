using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour
{
	public float tilt;

    public bool ENABLED = true;

	int multiply = 0;

    public float ROTATIONSPEED = -300;
	
	// Update is called once per frame
	void Update ()
    {
		//after 20 seconds the game speeds up
		if (Time.time > 20 && multiply == 0) 
		{
			ROTATIONSPEED = ROTATIONSPEED * 2f;

			//this is used to ensure that this only triggers once
			multiply++;
		}


		//continuously rotates the player's box as an animation
        if (ENABLED)
        {
            gameObject.transform.Rotate(0, 0, ROTATIONSPEED * Time.deltaTime);
        }
    }
}
