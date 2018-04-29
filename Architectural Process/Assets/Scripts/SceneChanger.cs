using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Room1")
        {
            SceneManager.LoadScene("Room1", LoadSceneMode.Single);
        }

        if (col.gameObject.tag == "Room2")
        {
            SceneManager.LoadScene("Room2", LoadSceneMode.Single);
        }

        if (col.gameObject.tag == "Room3")
        {
            SceneManager.LoadScene("Room3", LoadSceneMode.Single);
        }
    }
}
