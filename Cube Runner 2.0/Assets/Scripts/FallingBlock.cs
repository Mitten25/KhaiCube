using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlock : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.y < 1.5)
		{
			this.GetComponent<Rigidbody>().useGravity = false;
			this.GetComponent<Rigidbody>().velocity = Vector3.zero;
		}
	}
}
