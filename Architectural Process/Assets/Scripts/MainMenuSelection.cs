using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSelection : MonoBehaviour {

    public GameObject RedSquareCredits;
    public GameObject RedSquareMainMenu;
    public GameObject BlueCircleLearnMore;
    public GameObject BlueCircleMainMenu;

    public GameObject RedSquareCataracts;
    public GameObject RedSquareDiabetic;
    public GameObject RedSquareGlaucoma;
    public GameObject RedSquareMacular;

    public void OnLoadStart()
    {
        Debug.Log("START");
        SceneManager.LoadScene("office", LoadSceneMode.Single);
    }
    public void OnLoadMoreInfo()
    {
        BlueCircleLearnMore.SetActive(true);
        BlueCircleMainMenu.SetActive(false);
        Debug.Log("MORE INFO");
    }
    public void OnLoadCredits()
    {
        RedSquareCredits.SetActive(true);
        RedSquareMainMenu.SetActive(false);
        Debug.Log("CREDITS");
    }
    public void OnLoadQuit()
    {
        //SceneManager.LoadScene("selection_all", LoadSceneMode.Single);
        Debug.Log("QUIT");
    }

    public void OnLoadCataracts()
    {
        RedSquareCataracts.SetActive(true);
        RedSquareDiabetic.SetActive(false);
        RedSquareGlaucoma.SetActive(false);
        RedSquareMacular.SetActive(false);
        RedSquareMainMenu.SetActive(false);
    }

    public void OnLoadDiabetic()
    {
        RedSquareCataracts.SetActive(false);
        RedSquareDiabetic.SetActive(true);
        RedSquareGlaucoma.SetActive(false);
        RedSquareMacular.SetActive(false);
        RedSquareMainMenu.SetActive(false);
    }

    public void OnLoadGlaucoma()
    {
        RedSquareCataracts.SetActive(false);
        RedSquareDiabetic.SetActive(false);
        RedSquareGlaucoma.SetActive(true);
        RedSquareMacular.SetActive(false);
        RedSquareMainMenu.SetActive(false);
    }

    public void OnLoadMacular()
    {
        RedSquareCataracts.SetActive(false);
        RedSquareDiabetic.SetActive(false);
        RedSquareGlaucoma.SetActive(false);
        RedSquareMacular.SetActive(true);
        RedSquareMainMenu.SetActive(false);
    }

    public void OnLoadBack()
    {
        RedSquareCataracts.SetActive(false);
        RedSquareDiabetic.SetActive(false);
        RedSquareGlaucoma.SetActive(false);
        RedSquareMacular.SetActive(false);
        RedSquareMainMenu.SetActive(true);
        RedSquareCredits.SetActive(false);

        BlueCircleLearnMore.SetActive(false);
        BlueCircleMainMenu.SetActive(true);
    }
}
