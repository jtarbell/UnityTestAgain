using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	public Transform brick;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) {	
			Vector3 p = new Vector3(0,10,0);
			
			Transform newBrick = Instantiate(brick, p, Quaternion.Euler(0,Random.Range(0,90),0) ) as Transform;
			//newBrick.GetComponent<Rigidbody>().velocity = transform.forward * 10f;
		}
	}
}
