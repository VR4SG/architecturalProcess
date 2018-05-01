using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuickFilters : MonoBehaviour {

    public GameObject cataracts;
    public GameObject diabetes;
    public GameObject glaucoma;
    public GameObject macular;

    public GameObject normalUnselected;
    public GameObject cataractsUnselected;
    public GameObject diabetesUnselected;
    public GameObject glaucomaUnselected;
    public GameObject macularUnselected;

    public GameObject HUD;
    public Text stageText;

    int num = 0;

    // Update is called once per frame
    void Update () {

        if (HUD.activeSelf)
        {
            if ((OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger)) && (num > 0))
            {
                num--;
            }

            if ((OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger)) && (num < 4))
            {
                num++;
            }

            DetermineCondition(num);
        }        
    }

    void DetermineCondition(int number)
    {
        if(number == 0)
        {
            cataracts.SetActive(false);
            diabetes.SetActive(false);
            glaucoma.SetActive(false);
            macular.SetActive(false);

            normalUnselected.SetActive(false);
            cataractsUnselected.SetActive(true);
            diabetesUnselected.SetActive(true);
            glaucomaUnselected.SetActive(true);
            macularUnselected.SetActive(true);

            stageText.text = "0";
        }

        if(number == 1)
        {
            cataracts.SetActive(true);
            diabetes.SetActive(false);
            glaucoma.SetActive(false);
            macular.SetActive(false);

            normalUnselected.SetActive(true);
            cataractsUnselected.SetActive(false);
            diabetesUnselected.SetActive(true);
            glaucomaUnselected.SetActive(true);
            macularUnselected.SetActive(true);
        }

        if (number == 2)
        {
            cataracts.SetActive(false);
            diabetes.SetActive(true);
            glaucoma.SetActive(false);
            macular.SetActive(false);

            normalUnselected.SetActive(true);
            cataractsUnselected.SetActive(true);
            diabetesUnselected.SetActive(false);
            glaucomaUnselected.SetActive(true);
            macularUnselected.SetActive(true);
        }

        if (number == 3)
        {
            cataracts.SetActive(false);
            diabetes.SetActive(false);
            glaucoma.SetActive(true);
            macular.SetActive(false);

            normalUnselected.SetActive(true);
            cataractsUnselected.SetActive(true);
            diabetesUnselected.SetActive(true);
            glaucomaUnselected.SetActive(false);
            macularUnselected.SetActive(true);
        }

        if (number == 4)
        {
            cataracts.SetActive(false);
            diabetes.SetActive(false);
            glaucoma.SetActive(false);
            macular.SetActive(true);

            normalUnselected.SetActive(true);
            cataractsUnselected.SetActive(true);
            diabetesUnselected.SetActive(true);
            glaucomaUnselected.SetActive(true);
            macularUnselected.SetActive(false);
        }
    }
}
