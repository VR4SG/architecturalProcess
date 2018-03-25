using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassFaceInteraction : MonoBehaviour {

    public GameObject Glasses;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Cataracts" || col.gameObject.tag == "Diabetes" || col.gameObject.tag == "Glaucoma" || col.gameObject.tag == "Macular")
        {
            Glasses = col.gameObject;
            Glasses.SetActive(false);
        }
    }


}
