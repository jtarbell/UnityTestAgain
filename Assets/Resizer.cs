using UnityEngine;
using System.Collections;

public class Resizer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float ss = Random.Range (.2f,2.0f);
		this.transform.localScale = new Vector3(ss,ss,ss);
	}
	
	// Update is called once per frame
	void Update () {
		// kill self once falling
		if (this.transform.position.y<-10) {
			Destroy(this);
		}
	}
}
