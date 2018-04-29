using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsSelection : MonoBehaviour {

    public GameObject controllersPanel;
    public GameObject quickFilterPanel;

    public void OnLoadMainMenu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void OnLoadContinue()
    {
        
        quickFilterPanel.SetActive(true);
        controllersPanel.SetActive(false);
    }

    public void OnLoadBack()
    {
        controllersPanel.SetActive(true);
        quickFilterPanel.SetActive(false);
    }

    public void onLoadOffice()
    {
        SceneManager.LoadScene("Office", LoadSceneMode.Single);
    }


}
