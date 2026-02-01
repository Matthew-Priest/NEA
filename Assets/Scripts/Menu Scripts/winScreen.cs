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
        SceneManager.LoadSceneAsync(1);
    }
}
