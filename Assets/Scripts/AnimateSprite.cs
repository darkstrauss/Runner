using UnityEngine;
using System.Collections;

public class AnimateSprite : MonoBehaviour {

	public Renderer moveThis;
	public float SCROLLSPEED;

	int multiply = 0;

	void Start()
	{
		//calls for its own renderer component to enable changes to be made
		moveThis = GetComponent<Renderer> ();
	}

	void Update()
	{
		//after 20 seconds the game speeds up
		if (Time.time > 20 && multiply == 0) 
		{
			SCROLLSPEED = SCROLLSPEED * 2f;

			//this ensures that it is only executed once
			multiply++;
		}

		//this loops the offset value between 0 and 1
		float offset = Mathf.Repeat (-SCROLLSPEED * Time.time, 1.0f);

		//causes the material's offset to change, creating the effect of movement
		moveThis.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
	}
}
