using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassFaceInteraction : MonoBehaviour
{

    public GameObject Glasses;

    void OnTriggerEnter(Collider col)
    {
        Glasses = col.gameObject;

        if (col.gameObject.tag == "Cataracts")
        {
            DestroyObject(Glasses);
            Debug.Log("LINE 19");
        }
    }


}
