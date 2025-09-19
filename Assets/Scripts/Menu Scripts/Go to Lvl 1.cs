using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoLvl1 : MonoBehaviour
{
    public void lvl1()
    {
        SceneManager.LoadSceneAsync(0);
    }

}
