using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winScreen : MonoBehaviour
{
    string sceneName; /*gets level of active level so that script knows how many coins to award for win*/
    public GameObject WinUI;
    public Attributes Attributes;
    bool gamewon;
    public void stopGame()
    {
        WinUI.SetActive(true);
        Time.timeScale = 0;
        if(gamewon == false)
        {
            if (sceneName == "Level one")
            {
                Attributes.AttributeMoney += 5;
                gamewon = true;
            }
            else if (sceneName == "Level two")
            {
                Attributes.AttributeMoney += 10;
                gamewon = true;
            }
            else if (sceneName == "Level three")
            {
                Attributes.AttributeMoney += 15;
                gamewon = true;
            }
        }

    }
    public void Quit()
    {
        Debug.Log("exiting application");
        Application.Quit();
    }
    public void menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(1);
        
    }
    private void Awake()
    {
        sceneName = SceneManager.GetActiveScene().name;
        Attributes = Object.FindFirstObjectByType<Attributes>();
        gamewon = false;
    }
}
