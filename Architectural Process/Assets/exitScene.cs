using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitScene : MonoBehaviour {

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("EXIT");
            SceneManager.LoadScene("Office", LoadSceneMode.Single);
        }
    }
}
