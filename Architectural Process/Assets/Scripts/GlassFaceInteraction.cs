using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassFaceInteraction : MonoBehaviour {

    public GameObject Glasses;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Glasses")
        {
            Glasses.SetActive(false);
        }
    }


}
