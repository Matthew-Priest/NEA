using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoMenu : MonoBehaviour
{
    public void menu()
    {
        SceneManager.LoadSceneAsync(1);
    }

}
