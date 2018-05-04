using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCameraScript : MonoBehaviour {


    public float offset = 4.0f;	
	// Update is called once per frame
	void Update () {
        this.transform.position = (Camera.main.transform.position + Camera.main.transform.forward * offset);
	}
}
