using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour {
	
	// Update is called once per frame
	void Update ()
    {
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            SceneManager.LoadScene("ControllerRoom", LoadSceneMode.Single);
        }

        if (OVRInput.GetDown(OVRInput.Button.Start))
        {
            SceneManager.LoadScene("menu", LoadSceneMode.Single);
        }
    }
}
