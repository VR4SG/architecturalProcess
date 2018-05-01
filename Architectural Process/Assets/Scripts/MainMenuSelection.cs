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
        SceneManager.LoadScene("ControllerRoom", LoadSceneMode.Single);
    }

    public void OnLoadContinue()
    {
        SceneManager.LoadScene("Office", LoadSceneMode.Single);
    }

    public void OnLoadMainMenu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void OnLoadLearnMore()
    {
        BlueCircleLearnMore.SetActive(true);
        BlueCircleMainMenu.SetActive(false);
    }

    public void OnLoadCredits()
    {
        RedSquareCredits.SetActive(true);
        RedSquareMainMenu.SetActive(false);
    }

    public void OnLoadQuit()
    {
        Debug.Log("QUIT");
        Application.Quit();
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
