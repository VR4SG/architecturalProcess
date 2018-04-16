using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSelection : MonoBehaviour {

    public GameObject Credits;
    public GameObject InfoBlueCircle;

    public void OnLoadStart()
    {
        Debug.Log("START");
        SceneManager.LoadScene("office", LoadSceneMode.Single);
    }
    public void OnLoadMoreInfo()
    {
        InfoBlueCircle.SetActive(true);
        Debug.Log("MORE INFO");
    }
    public void OnLoadCredits()
    {
        Credits.SetActive(true);
        Debug.Log("CREDITS");
    }
    public void OnLoadQuit()
    {
        //SceneManager.LoadScene("selection_all", LoadSceneMode.Single);
        Debug.Log("QUIT");
    }
}
