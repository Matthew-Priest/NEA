using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoLvl1 : MonoBehaviour
{
    public void lvl1()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(0);
    }

}
