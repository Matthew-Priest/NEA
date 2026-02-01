using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loseScreen : MonoBehaviour
{
    public GameObject LoseUI;
    public void stopGame()
    {
        LoseUI.SetActive(true);
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
