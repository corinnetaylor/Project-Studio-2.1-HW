using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		Debug.Log(Time.time);
		
		
		if (Time.time < 7){
			transform.Translate (-2*Time.deltaTime,0*Time.deltaTime,0*Time.deltaTime);
		}
		if (Time.time > 11 && Time.time < 28){
			transform.Translate (0*Time.deltaTime,0*Time.deltaTime,-2*Time.deltaTime);
		}
		if (Time.time > 36 && Time.time < 44){
			transform.Translate (0*Time.deltaTime,-2*Time.deltaTime,0*Time.deltaTime);
		}
		if (Time.time > 44 && Time.time < 63){
			transform.Translate (3*Time.deltaTime,0*Time.deltaTime,0*Time.deltaTime);
		}
		if (Time.time > 50 && Time.time < 59){
			transform.Rotate (0*Time.deltaTime,-10*Time.deltaTime,0*Time.deltaTime);
		}
		if (Time.time > 63 && Time.time < 68){
			transform.Translate (0*Time.deltaTime,0*Time.deltaTime,2*Time.deltaTime);
		}
	}
}
