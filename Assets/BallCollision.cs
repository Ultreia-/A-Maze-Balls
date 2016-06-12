using UnityEngine;
using System.Collections;

public class BallCollision : MonoBehaviour {

	CheckForWinnerScript winnerScript;

	// Use this for initialization
	void Start () {
		winnerScript = GameObject.Find("CheckForWinner").GetComponent<CheckForWinnerScript>();

	}
	
	// Update is called once per frame
	void Update () {
			
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("Collision Detected!");
		if (other.gameObject.name == "TriggerPlane") {
			StartCoroutine (resetLevel ());
		}

		if (other.gameObject.name == "Goal1Trigger") {
			Debug.Log ("GoalZone1");
			winnerScript.isInGoalZone1 = true;

		}
		if (other.gameObject.name == "Goal2Trigger") {
			Debug.Log ("GoalZone2");
			winnerScript.isInGoalZone2 = true;
		}

	}
		
	void OnTriggerExit(Collider other)
	{
		Debug.Log ("Exit Detected!");

		if (other.gameObject.name == "Goal1Trigger") {
			winnerScript.isInGoalZone1 = false;
		}
		if (other.gameObject.name == "Goal2Trigger") {
			winnerScript.isInGoalZone2 = false;
		}

	}

	IEnumerator resetLevel() {
		yield return new WaitForSeconds(2);
		Application.LoadLevel(Application.loadedLevel);
	}
}
