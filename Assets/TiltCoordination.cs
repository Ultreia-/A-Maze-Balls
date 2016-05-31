using UnityEngine;
using System.Collections;

public class TiltCoordination : MonoBehaviour {

	public Transform gameArea;
	public Transform trigger;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		trigger.transform.rotation = gameArea.transform.rotation;
	}
}
