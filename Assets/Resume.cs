using UnityEngine;
using UnityEngine.SceneManagement;

public class Resume : MonoBehaviour
{
    public void resume_game()
    {
        int sceneindex;
        sceneindex = SceneManager.GetActiveScene().buildIndex;
        if (sceneindex == 0)
        {
            
        }
    }

}
