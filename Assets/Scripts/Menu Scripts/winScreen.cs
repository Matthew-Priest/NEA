using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winScreen : MonoBehaviour
{
    string sceneName; /*gets level of active level so that script knows how many coins to award for win*/
    public GameObject WinUI;
    public Attributes Attributes;
    public void stopGame()
    {
        WinUI.SetActive(true);
        Time.timeScale = 0;
        if(sceneName == "Level one")
        {
            Attributes.AttributeMoney += 5;
        } else if(sceneName == "Level two")
        {
            Attributes.AttributeMoney += 10;
        }else if (sceneName == "Level three")
        {
            Attributes.AttributeMoney += 15;
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
    }
}
