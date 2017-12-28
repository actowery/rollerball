using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		// ...also rotate around the World's Y axis
		transform.Rotate(new Vector3(15,30,15)*Time.deltaTime);
	}
}
