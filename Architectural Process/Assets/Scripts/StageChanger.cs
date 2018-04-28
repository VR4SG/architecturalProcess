using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageChanger : MonoBehaviour {

    public GameObject stage1;
    public GameObject stage2;
    public GameObject stage3;
    public GameObject stage4;
    public GameObject stage5;
    public GameObject stage6;
    public GameObject stage7;
    public GameObject stage8;
    public GameObject stage9;
    public GameObject stage10;
    int stage;

    public Text stageText;
    public GameObject sliderPanel;
    public GameObject condition;

    private void Start()
    {
        stage = 1;
        stageText.text = "Severity Level: " + stage.ToString();
    }

    // Update is called once per frame
    void Update () {

        stageText.text = stage.ToString();

        if ((OVRInput.GetDown(OVRInput.Button.Two)) && (stage < 10))
        {
            stage++;
            sliderPanel.SetActive(true);

            /*StartCoroutine(DisablePanel(5, sliderPanel));*/
        }

        if ((OVRInput.GetDown(OVRInput.Button.One)) && (stage > 1))
        {
            stage--;
            sliderPanel.SetActive(true);

            /*StartCoroutine(DisablePanel(5, sliderPanel));*/
        }

        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            Debug.Log("OVR INPUT BUTTON FOUR");
        }

        if (stage == 1)
        {
            stage1.SetActive(true);
            stage2.SetActive(false);
            stage3.SetActive(false);
            stage4.SetActive(false);
            stage5.SetActive(false);
            stage6.SetActive(false);
            stage7.SetActive(false);
            stage8.SetActive(false);
            stage9.SetActive(false);
            stage10.SetActive(false);
        }

        if (stage == 2)
        {
            stage1.SetActive(false);
            stage2.SetActive(true);
            stage3.SetActive(false);
            stage4.SetActive(false);
            stage5.SetActive(false);
            stage6.SetActive(false);
            stage7.SetActive(false);
            stage8.SetActive(false);
            stage9.SetActive(false);
            stage10.SetActive(false);
        }

        if (stage == 3)
        {
            stage1.SetActive(false);
            stage2.SetActive(false);
            stage3.SetActive(true);
            stage4.SetActive(false);
            stage5.SetActive(false);
            stage6.SetActive(false);
            stage7.SetActive(false);
            stage8.SetActive(false);
            stage9.SetActive(false);
            stage10.SetActive(false);
        }

        if (stage == 4)
        {
            stage1.SetActive(false);
            stage2.SetActive(false);
            stage3.SetActive(false);
            stage4.SetActive(true);
            stage5.SetActive(false);
            stage6.SetActive(false);
            stage7.SetActive(false);
            stage8.SetActive(false);
            stage9.SetActive(false);
            stage10.SetActive(false);
        }

        if (stage == 5)
        {
            stage1.SetActive(false);
            stage2.SetActive(false);
            stage3.SetActive(false);
            stage4.SetActive(false);
            stage5.SetActive(true);
            stage6.SetActive(false);
            stage7.SetActive(false);
            stage8.SetActive(false);
            stage9.SetActive(false);
            stage10.SetActive(false);
        }

        if (stage == 6)
        {
            stage1.SetActive(false);
            stage2.SetActive(false);
            stage3.SetActive(false);
            stage4.SetActive(false);
            stage5.SetActive(false);
            stage6.SetActive(true);
            stage7.SetActive(false);
            stage8.SetActive(false);
            stage9.SetActive(false);
            stage10.SetActive(false);
        }

        if (stage == 7)
        {
            stage1.SetActive(false);
            stage2.SetActive(false);
            stage3.SetActive(false);
            stage4.SetActive(false);
            stage5.SetActive(false);
            stage6.SetActive(false);
            stage7.SetActive(true);
            stage8.SetActive(false);
            stage9.SetActive(false);
            stage10.SetActive(false);
        }

        if (stage == 8)
        {
            stage1.SetActive(false);
            stage2.SetActive(false);
            stage3.SetActive(false);
            stage4.SetActive(false);
            stage5.SetActive(false);
            stage6.SetActive(false);
            stage7.SetActive(false);
            stage8.SetActive(true);
            stage9.SetActive(false);
            stage10.SetActive(false);
        }

        if (stage == 9)
        {
            stage1.SetActive(false);
            stage2.SetActive(false);
            stage3.SetActive(false);
            stage4.SetActive(false);
            stage5.SetActive(false);
            stage6.SetActive(false);
            stage7.SetActive(false);
            stage8.SetActive(false);
            stage9.SetActive(true);
            stage10.SetActive(false);
        }

        if (stage == 10)
        {
            stage1.SetActive(false);
            stage2.SetActive(false);
            stage3.SetActive(false);
            stage4.SetActive(false);
            stage5.SetActive(false);
            stage6.SetActive(false);
            stage7.SetActive(false);
            stage8.SetActive(false);
            stage9.SetActive(false);
            stage10.SetActive(true);
        }
    }

    /*IEnumerator DisablePanel(int seconds, GameObject panel)
    {
        Debug.Log("INSIDE OF DISABLE PANEL FUNCTION");
        yield return new WaitForSeconds(seconds);
        panel.SetActive(false);
    }*/
}
