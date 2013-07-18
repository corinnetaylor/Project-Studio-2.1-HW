using UnityEngine;
using System.Collections;

public class CatapultButton : MonoBehaviour {
	
	public Transform catapult;
	public float xValue;
	bool rotate = false;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (rotate && catapult.rotation.x > -.7f){
			catapult.Rotate (xValue*Time.deltaTime,0,0);
			//Debug.Log (catapult.rotation.x);
		}
	}
	
		void OnTriggerEnter(){
	
		Debug.Log("Button Pressed");
		rotate = true;

	}
}

