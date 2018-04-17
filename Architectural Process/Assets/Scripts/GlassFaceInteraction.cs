using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassFaceInteraction : MonoBehaviour {

    public GameObject Glasses;
    public GameObject Condition;
    public Transform RespawnLocation;
    Vector3 RespawnPosition;

    private void Start()
    {
        RespawnPosition = new Vector3(RespawnLocation.transform.position.x, RespawnLocation.transform.position.y, RespawnLocation.transform.position.z);
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Cataracts") {
            Glasses.gameObject.transform.position = RespawnPosition;
            Glasses.gameObject.transform.rotation = Quaternion.Euler(0, 90, 0);
            Condition.SetActive(true);
        }
    }
}
