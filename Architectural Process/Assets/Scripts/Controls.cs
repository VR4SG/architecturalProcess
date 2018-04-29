using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour
{

    public GameObject HUD;

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            HUD.SetActive(!HUD.activeSelf);
        }

        if (OVRInput.GetDown(OVRInput.Button.Start))
        {
            //SceneManager.LoadScene("menu", LoadSceneMode.Single);
            Debug.Log("TO BE DETERMINED");
        }
    }
}
