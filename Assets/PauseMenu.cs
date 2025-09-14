using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool paused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (paused == true)
            {
                Resume();
            }
            else if (paused == false)
            {
                Pause();
            }
        }
        void Resume()
        {
            pauseMenuUI.active = false;
            Time.timeScale = 1f;
            paused = false;
        }
        void Pause()
        {
            pauseMenuUI.active = true;
            Time.timeScale = 0f;
            paused = true;
        }
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
    public void resume()
    {
        pauseMenuUI.active = false;
        Time.timeScale = 1f;
        paused = false;
    }
}
