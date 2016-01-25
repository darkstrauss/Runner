using UnityEngine;
using System.Collections;

public class CoinAnimation : MonoBehaviour
{
	
	public bool ENABLED = true;
	
	public int ROTATIONSPEED = -300;
	
	// Update is called once per frame
	void Update ()
	{
		if (ENABLED)
		{
			//continuously rotates the coin as an animation
			gameObject.transform.Rotate(ROTATIONSPEED * Time.deltaTime, 0, 0);
		}
	}
}
