using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	//storage

	int PlayerScore = 0 ;
	int EnemyScore = 0 ;

	public GUISkin ScoreSkin;

	// Use this for initialization


	public void IncreaseScore(int PlayerType){
	
		if (PlayerType == 1) 
		{
			PlayerScore ++;
		} 
		else if (PlayerType == 2) 
		{
			EnemyScore ++;
		} 
		else 
		{
			print("Error!");		
		}	
	}

	void OnGUI()
	{
		/*if (GUI.skin != ScoreSkin) 
		{
			GUI.skin = ScoreSkin;
		
		}*/

		GUI.Label (new Rect (10, 10, 300, 30), "Player Score : " + PlayerScore.ToString ());
		GUI.Label (new Rect (10, 35, 300, 30), "Enemy Score : " + EnemyScore.ToString ());

	}


}
