using UnityEngine;
using System.Collections;

public class ResetBonus : MonoBehaviour {

	//When the gameObject collides with the player, the gameObject gets detroyed and score bonus is reset in the PlayerStats component on the player.
	void OnTriggerEnter(Collider box)
	{
		Destroy (gameObject);
		PlayerStats resetBonus = box.transform.parent.gameObject.GetComponent<PlayerStats>();
		resetBonus.ResetBonus ();
	}
}
