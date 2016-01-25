using UnityEngine;
using System.Collections;

public class Jumping : MonoBehaviour
{
    public bool grounded = true;
    public bool hasJumped = false;

    public bool pressingLeft;
    public bool pressingRight;
    public bool pressingAButton;

    //bounds for the player movement left and right
    public float zMin;
	public float zMax;

	PlayerStats addingScore;

    void Start()
    {
        pressingLeft = false;
        pressingRight = false;
        pressingAButton = false;
    }
    
    void Update()
    {
		//checks if the player is on the ground, as well as the player pressing the space bar. If this has been met it sets hasJumped to true and adds a time jumped to the playerstats
		if (grounded && Input.GetButtonDown("Fire1") && !pressingAButton)
		{
			hasJumped = true;

			addingScore = gameObject.GetComponent("PlayerStats") as PlayerStats;
			addingScore.TimesJumped++;
		}

		//when hasJumped is true it moves the player up at a constant rate
        if (hasJumped)
        {
            gameObject.transform.Translate(0.0f, 5.0f * Time.deltaTime, 0.0f);
            grounded = false;
        }

		//when the player has reached a certain height hasJumped gets set to false to stop the movement upwards
        if (gameObject.transform.position.y > 0 && !grounded)
        {
			hasJumped = false;
        }

		//if the player is not grounded and hasJumped is also false the player is in the air. This makes sure that the player starts moving back towards the ground
		if (!grounded && !hasJumped) 
		{
			gameObject.transform.Translate(0.0f, -5.0f * Time.deltaTime, 0.0f);
		}

		//when the player reaches the ground, grounded gets set back to true to disable the downwards movement, and enables the player to once again jump
		if (gameObject.transform.position.y < -2.4f)
        {
			grounded = true;
        }

		//listens for the "A" key to be pressed. if the player is not too far to the left the cube moves left
		if (pressingLeft && gameObject.transform.position.z < zMin)
		{
			gameObject.transform.Translate(0.0f, 0.0f, 0.02f);
		}

		//listens for the "D" key to be pressed. if the player is not too far to the right the cube moves right
		if (pressingRight && gameObject.transform.position.z > zMax)
		{
			gameObject.transform.Translate(0.0f, 0.0f, -0.02f);
		}
    }

    public void PressingUILeft()
    {
        pressingAButton = true;
        pressingLeft = true;
    }

    public void ReleaseUILeft()
    {
        pressingAButton = false;
        pressingLeft = false;
    }

    public void PressingUIRight()
    {
        pressingAButton = true;
        pressingRight = true;
    }

    public void ReleaseUIRight()
    {
        pressingAButton = false;
        pressingRight = false;
    }
}
