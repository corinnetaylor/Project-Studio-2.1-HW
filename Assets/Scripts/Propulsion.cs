using UnityEngine;
using System.Collections;

public class Propulsion : MonoBehaviour {
	
	public Transform catapult; //set in inspector
	float startTime = 48;
	public float duration = 2; //set in inspector
	public float distance = 5; //set in inspector
	public float fire = 48;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Time.time > fire && startTime + duration > Time.time){
			
			Debug.Log ("FIRE");
		
			transform.Translate(0, 0, -distance *Time.deltaTime);
			
		}
		
	}
}
