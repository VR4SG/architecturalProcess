using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasterEgg : MonoBehaviour {

	// Update is called once per frame
	void OnTriggerEnter (Collider col) {
		if(col.gameObject.tag == "Pear")
        {
            SceneManager.LoadScene("Basketball", LoadSceneMode.Single);
            Debug.Log("EASTER EGG!");
        }
	}
}
