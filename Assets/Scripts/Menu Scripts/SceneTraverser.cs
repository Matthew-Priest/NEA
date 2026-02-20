using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTraverser : MonoBehaviour
{
    public void settings()
    {
        SceneManager.LoadSceneAsync(3);
    }
    public void menu()
    {
        SceneManager.LoadSceneAsync(1);

    }
    public void levelSelection()
    {
        SceneManager.LoadSceneAsync(2);

    }
    public void lvl1()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(0);
    }
    public void lvl2()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(4);
    }
    public void lvl3()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(5);
    }
}
