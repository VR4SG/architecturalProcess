using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsSelection : MonoBehaviour {

    public void OnLoadContinue()
    {
        SceneManager.LoadScene("Office", LoadSceneMode.Single);
    }

    public void OnLoadMainMenu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
