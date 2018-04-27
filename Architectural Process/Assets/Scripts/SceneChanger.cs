using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Room2")
        {
            Debug.Log("CHANGE INTO SPEC STORE");
            SceneManager.LoadScene("Room2", LoadSceneMode.Single);
        }
	}
}
