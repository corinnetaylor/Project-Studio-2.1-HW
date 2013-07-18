using UnityEngine;
using System.Collections;

public class BlockMove : MonoBehaviour {
	
	public Transform pushCube; //assign in inspector
	public Transform sphere5; //assign in inspector
	bool move = false;
	float startTime;
	public float duration = 5; //assign in inspector
	public float xMove = 5; //assign in inspector
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (move && startTime + duration > Time.time){
			pushCube.transform.Translate (xMove *Time.deltaTime, 0, 0);
		}
	}
	
		void OnTriggerEnter(Collider sphere5){
	
		if (sphere5.name == "Sphere5"){
			Debug.Log("Button Pressed");
			move = true;
			startTime = Time.time;
		}
			
	}
}
