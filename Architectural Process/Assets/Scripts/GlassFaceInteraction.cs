using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassFaceInteraction : MonoBehaviour {

    public GameObject Glasses;
    public GameObject Condition;

    void OnTriggerEnter(Collider col)
    {
        Glasses = col.gameObject;

        if (col.gameObject.tag == "Cataracts")
        {
            DestroyObject(Glasses);

            if(col.gameObject.tag == "Cataracts")
            {
                Condition.SetActive(true);
            }
        }
    }


}
