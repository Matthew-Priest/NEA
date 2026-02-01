using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winScreen : MonoBehaviour
{
    public GameObject WinUI;
    public void stopGame()
    {
        WinUI.SetActive(true);
        Time.timeScale = 0;
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
}
