using UnityEngine;
using System.Collections;

public class Button_Rotate : MonoBehaviour {
	
	public Transform rotateCube;
	public float xValue;
	public float yValue;
	public float zValue;
	bool rotate = false;
	bool moveButton;
	float startTime;
	public float duration;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (rotate && startTime + duration > Time.time){
			rotateCube.Rotate (xValue*Time.deltaTime,yValue*Time.deltaTime,zValue*Time.deltaTime);
		}
	}
	
		void OnTriggerEnter(){
	
		Debug.Log("Button Pressed");
		rotate = true;
		startTime = Time.time;

	}
}
