using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderChange : MonoBehaviour {

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

    private void Start()
    {
        stage = 1;
    }

    // Update is called once per frame
    void Update () {
        Debug.Log("INITIAL STAGE: " + stage);

        if ((OVRInput.GetDown(OVRInput.Button.Two)) && (stage < 10))
        {
            stage++;
            Debug.Log("STAGE CHANGE: " + stage);
        }

        if ((OVRInput.GetDown(OVRInput.Button.One)) && (stage > 1))
        {
            stage--;
            Debug.Log("STAGE CHANGE: " + stage);
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

            changeStage(stage);
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

            changeStage(stage);
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

            changeStage(stage);
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

            changeStage(stage);
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

            changeStage(stage);
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

            changeStage(stage);
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

            changeStage(stage);
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

            changeStage(stage);
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

            changeStage(stage);
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

            changeStage(stage);
        }

    }

    void changeStage(int stage)
    {
        if ((OVRInput.GetDown(OVRInput.Button.Two)))
        {
            stage++;
            Debug.Log("STAGE CHANGE: " + stage);
        }

        if ((OVRInput.GetDown(OVRInput.Button.One)))
        {
            stage--;
            Debug.Log("STAGE CHANGE: " + stage);
        }
    }
}
