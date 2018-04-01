using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassFaceInteraction : MonoBehaviour {

    public GameObject Glasses;
    public GameObject Condition;

    void OnTriggerEnter(Collider col)
    {
        Glasses = col.gameObject;

        if (col.gameObject.tag == "Cataracts" || col.gameObject.tag == "Diabetes" || col.gameObject.tag == "Glaucoma" || col.gameObject.tag == "Macular")
        {
            //Glasses.SetActive(false);
            DestroyObject(Glasses);

            if(col.gameObject.tag == "Cataracts")
            {
                //DestroyObject(Condition);
                Condition.SetActive(true);
            }
        }
    }


}
