using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour 
{
    public int Score;
	public int Bonus;
	public int TimeInSeconds;
	private float timePlaying;
	private float previeousTime;
	public int TimesJumped;

    public Text scoreText;


    void Start()
    {
		//player score
        Score = 0;

		//amount of time playing in seconds
        timePlaying = 0;

		//amount of times jumped by the player
        TimesJumped = 0;

		//value used to calculate bonus score for every coin grabbed
		Bonus = 0;

    }

	public void AddScore(int addPoints)
	{
		//adds score to the score stat
		Score = Score + addPoints + (addPoints * (10 * Bonus));
		Bonus++;
        scoreText.text = "Score: " + Score;
	}

	public void ResetBonus()
	{
		Bonus = 0;
	}

	//custom timer to keep track of time in whole seconds
	void Update()
	{
		previeousTime = Time.deltaTime;
		timePlaying = timePlaying + previeousTime;

		TimeInSeconds = Mathf.FloorToInt (timePlaying);
	}

}
