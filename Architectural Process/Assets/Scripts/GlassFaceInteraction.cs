using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassFaceInteraction : MonoBehaviour {

    public GameObject Glasses;
    public GameObject Condition;
    public Transform Spawnpoint;

    void OnTriggerEnter(Collider col)
    {
        GameObject NewGlasses = Glasses;
        NewGlasses.SetActive(true);

        if (col.gameObject.tag == "Cataracts")
        {
            DestroyObject(Glasses.gameObject);
            Condition.SetActive(true);
        }
    }


}
