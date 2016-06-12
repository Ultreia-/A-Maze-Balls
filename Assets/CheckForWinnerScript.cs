using UnityEngine;
using System.Collections;

public class CheckForWinnerScript : MonoBehaviour {

	public bool isInGoalZone1 = false;
	public bool isInGoalZone2 = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (isInGoalZone1 && isInGoalZone2) {
			Debug.Log ("Game finished!");
			//Winning Text Goes Here
			resetLevel();
		}
	}

	IEnumerator resetLevel() {
		yield return new WaitForSeconds(2);
		Application.LoadLevel(Application.loadedLevel);
	}

}