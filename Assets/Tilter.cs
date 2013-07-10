using UnityEngine;
using System.Collections;

public class Tilter : MonoBehaviour {
	public float rotationSpeed = 100f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown("left")) {
			transform.Rotate(Vector3.forward*rotationSpeed);
		}
		if (Input.GetKeyDown("right")) {
			transform.Rotate(-Vector3.forward*rotationSpeed);
		}
		
	
	}
}
