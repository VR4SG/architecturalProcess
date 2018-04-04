using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassFaceInteraction : MonoBehaviour {

    public GameObject Glasses;
    public GameObject Condition;

    void OnTriggerEnter(Collider col) {

        if (col.gameObject.tag == "Cataracts") {
            DestroyObject(Glasses);
            Condition.SetActive(true);
        }
    }
}
