using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text score;
    int scoreNum;

	// Use this for initialization
	void Start () {
        scoreNum = 0;
        score.text = scoreNum.ToString();
	}

    void OnTriggerEnter (Collider col) {
		if(col.gameObject.tag == "Basketball")
        {
            scoreNum++;
            score.text = scoreNum.ToString();
        }
	}
}
