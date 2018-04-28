using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickFilters : MonoBehaviour {

    public GameObject cataracts;
    public GameObject diabetes;
    public GameObject glaucoma;
    public GameObject macular;
    int num = 1;

    // Update is called once per frame
    void Update () {
        if ((OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger) > 0.5) && (num > 1))
        {
            num--;
            //Debug.Log(num);
        }

        if ((OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) > 0.5) && (num <= 80))
        {
            num++;
            //Debug.Log(num);
        }

        DetermineCondition(num / 20);
    }

    void DetermineCondition(int number)
    {
        if(number == 1)
        {
            cataracts.SetActive(true);
            diabetes.SetActive(false);
            glaucoma.SetActive(false);
            macular.SetActive(false);
            Debug.Log(number + ": CATARACTS");
        }
        if (number == 2)
        {
            cataracts.SetActive(false);
            diabetes.SetActive(true);
            glaucoma.SetActive(false);
            macular.SetActive(false);
            Debug.Log(number + ": DIABETES");
        }
        if (number == 3)
        {
            cataracts.SetActive(false);
            diabetes.SetActive(false);
            glaucoma.SetActive(true);
            macular.SetActive(false);
            Debug.Log(number + ": GLAUCOMA");
        }
        if (number == 4)
        {
            cataracts.SetActive(false);
            diabetes.SetActive(false);
            glaucoma.SetActive(false);
            macular.SetActive(true);
            Debug.Log(number + ": MACULAR");
        }
    }
}
