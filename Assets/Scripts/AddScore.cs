using UnityEngine;
using System.Collections;

public class AddScore : MonoBehaviour {

	//When the gameObject collides with the player, the gameObject gets detroyed and score is added to the PlayerStats component on the player.
	void OnTriggerEnter(Collider box)
	{
		Destroy (gameObject);
		PlayerStats addingScore = box.transform.parent.gameObject.GetComponent<PlayerStats>();
		addingScore.AddScore (1);
	}

}
