using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour {

    public GameObject quickFilter;
	
    // Update is called once per frame
	void Update ()
    {
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            quickFilter.SetActive(!quickFilter.activeSelf);
        }

        if (OVRInput.GetDown(OVRInput.Button.Start))
        {
            SceneManager.LoadScene("menu", LoadSceneMode.Single);
        }
    }
}
