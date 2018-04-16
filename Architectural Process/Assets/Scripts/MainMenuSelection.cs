using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSelection : MonoBehaviour {

    public void OnLoadStart()
    {
        //SceneManager.LoadScene("selection_ui", LoadSceneMode.Single);
        Debug.Log("START");
    }
    public void OnLoadMoreInfo()
    {
        //SceneManager.LoadScene("selection_raw", LoadSceneMode.Single);
        Debug.Log("MORE INFO");
    }
    public void OnLoadCredits()
    {
        //SceneManager.LoadScene("selection_physics", LoadSceneMode.Single);
        Debug.Log("CREDITS");
    }
    public void OnLoadQuit()
    {
        //SceneManager.LoadScene("selection_all", LoadSceneMode.Single);
        Debug.Log("QUIT");
    }
}
