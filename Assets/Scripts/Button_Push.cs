using UnityEngine;
using System.Collections;

public class Button_Push : MonoBehaviour {

	public Transform pushCube;
	public float xValue;
	public float yValue;
	public float zValue;
	public float buttonMoveX;
	public float buttonMoveY;
	public float buttonMoveZ;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(){
	
		Debug.Log("Button Pressed");
		transform.Translate(buttonMoveX *Time.deltaTime, buttonMoveY *Time.deltaTime, buttonMoveZ*Time.deltaTime); //Behavior for the button to appear pressed
		pushCube.Translate(xValue, yValue, zValue); //Controls the Object being pressed
		
	}
	
}
