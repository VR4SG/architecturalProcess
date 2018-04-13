﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitCondition : MonoBehaviour {

    public GameObject Condition;

    // Use this for initialization
    void Start ()
    {    }

    // Update is called once per frame
    void Update ()
    {
        if (OVRInput.GetDown(OVRInput.Button.Four)) {
            Condition.SetActive(false);
        }
    }
}
