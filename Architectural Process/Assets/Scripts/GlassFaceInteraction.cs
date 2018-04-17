using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassFaceInteraction : MonoBehaviour {

    // CATARACTS
    public GameObject cataractsGlasses;
    public GameObject cataractsCondition;
    public Transform cataractsRespawnLocation;
    Vector3 cataractsRespawnPosition;

    // DIABETES
    public GameObject diabetesGlasses;
    public GameObject diabetesCondition;
    public Transform diabetesRespawnLocation;
    Vector3 diabetesRespawnPosition;

    private void Start()
    {
        cataractsRespawnPosition = new Vector3(cataractsRespawnLocation.transform.position.x, cataractsRespawnLocation.transform.position.y, cataractsRespawnLocation.transform.position.z);
        diabetesRespawnPosition = new Vector3(diabetesRespawnLocation.transform.position.x, diabetesRespawnLocation.transform.position.y, diabetesRespawnLocation.transform.position.z);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Cataracts") {
            cataractsGlasses.gameObject.transform.position = cataractsRespawnPosition;
            cataractsGlasses.gameObject.transform.rotation = Quaternion.Euler(0, 90, 0);
            cataractsCondition.SetActive(true);
        }

        if (col.gameObject.tag == "Diabetes")
        {
            diabetesGlasses.gameObject.transform.position = diabetesRespawnPosition;
            diabetesGlasses.gameObject.transform.rotation = Quaternion.Euler(0, 90, 0);
            diabetesCondition.SetActive(true);
        }
    }
}
