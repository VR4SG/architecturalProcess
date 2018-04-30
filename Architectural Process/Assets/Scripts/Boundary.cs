using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour {

    // BASKETBALL
    public GameObject basketball;
    public GameObject location;
    Vector3 basketballRespawn;

    private void Start()
    {
        basketballRespawn = new Vector3(location.transform.position.x, location.transform.position.y, location.transform.position.z);
    }

    // Update is called once per frame
    void OnTriggerEnter (Collider col) {
        if (col.gameObject.tag == "Basketball")
        {
            basketball.gameObject.transform.position = basketballRespawn;
        }
	}
}
