using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerModelPosition : MonoBehaviour {

    public Transform AnchorLocation;
    public Transform Controller;
    Vector3 ControllerLocation;

    // Use this for initialization
    /*void Start () {
        ControllerLocation = new Vector3(AnchorLocation.transform.position.x, AnchorLocation.transform.position.y, AnchorLocation.transform.position.z);
	}*/
	
	// Update is called once per frame
	void Update () {
        ControllerLocation = new Vector3(AnchorLocation.transform.position.x+3, AnchorLocation.transform.position.y+3, AnchorLocation.transform.position.z+3);
        Controller.transform.position = new Vector3(2, 2, 2);
    }
}
