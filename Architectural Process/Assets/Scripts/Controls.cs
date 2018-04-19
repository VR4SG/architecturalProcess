using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour {

    public GameObject Panel;
	
	// Update is called once per frame
	void Update ()
    {
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            if (Panel.activeSelf) {
                Panel.SetActive(false);
            }

            else
            {
                Panel.SetActive(true);
            }
        }

        if (OVRInput.GetDown(OVRInput.Button.Start))
        {
            SceneManager.LoadScene("menu", LoadSceneMode.Single);
        }
    }
}
