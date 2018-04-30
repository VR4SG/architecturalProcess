using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBasketball : MonoBehaviour {

    // BASKETBALL
    public GameObject basketball;
    public GameObject location;
    Vector3 basketballRespawn;

    private void Start()
    {
        basketballRespawn = new Vector3(location.transform.position.x, location.transform.position.y, location.transform.position.z);
    }

    // Update is called once per frame
    void Update () {

        basketballRespawn = new Vector3(location.transform.position.x, location.transform.position.y, location.transform.position.z);

        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            basketball.gameObject.transform.position = basketballRespawn;
        }
	}
}
