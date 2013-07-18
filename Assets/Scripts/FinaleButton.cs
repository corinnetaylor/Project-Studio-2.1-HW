using UnityEngine;
using System.Collections;

public class FinaleButton : MonoBehaviour {

	
	public TextMesh Hooray; //assign in inspector
	
	// Use this for initialization
	void Start () {
	

	}
	
		// Update is called once per frame
	void Update () {
		
		
	}
	
		void OnTriggerEnter(){
		
		//displays light and text
		
		light.enabled = true;
		Hooray.text = "Hooray!";
		
		
	}
}

