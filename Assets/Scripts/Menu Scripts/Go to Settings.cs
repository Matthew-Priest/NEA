using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoSettings : MonoBehaviour
{
    public void settings()
    {
        SceneManager.LoadSceneAsync(3);
    }
}
