using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void OnButtonClick()
    {
        Time.timeScale = 0;
        SceneManager.LoadSceneAsync(3);
    }
}
