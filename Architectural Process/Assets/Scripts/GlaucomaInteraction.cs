using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class GlaucomaInteraction : MonoBehaviour {

    public GameObject Glasses;
    public VignetteAndChromaticAberration vig;

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Glaucoma")
        {
            DestroyObject(Glasses);
            vig.enabled = true;
        }
    }

}
