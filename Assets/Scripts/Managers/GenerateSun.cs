using UnityEngine;
using UnityEngine.SceneManagement;

public class GenerateSun : MonoBehaviour
{
    public float timer;
    public int SpawnCount = 0;
    public GameObject Sun;
    string sceneName;
    int maxTime;
    public lvl1Settings lvl1;
    public lvl2Settings lvl2;
    public lvl3Settings lvl3;
    private void Update()
    {
        int rng = Random.Range(10, maxTime); // timer to generate
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = rng;
            makeSun();
        }
    }
    private void makeSun()
    {
        float range = Random.Range(0f, 14f); // x coords
        Vector3 sunspawncoords = new Vector3(range, 0, 1);
        Instantiate(Sun,sunspawncoords,Quaternion.identity);
        Debug.Log("sun made normally");
    }
    private void Start()
    {
        lvl1 = Object.FindFirstObjectByType<lvl1Settings>();
        lvl2 = Object.FindFirstObjectByType<lvl2Settings>();
        lvl3 = Object.FindFirstObjectByType<lvl3Settings>();
        sceneName = SceneManager.GetActiveScene().name;       
        if (sceneName == "Level one")
        {
            maxTime = Mathf.RoundToInt(lvl1.generationCooldown);
            Debug.Log(maxTime);
        }
        else if (sceneName == "Level two")
        {
            maxTime = Mathf.RoundToInt(lvl2.generationCooldown);
        }
        else if (sceneName == "Level three")
        {
            maxTime = Mathf.RoundToInt(lvl3.generationCooldown);
        }
    }

}
