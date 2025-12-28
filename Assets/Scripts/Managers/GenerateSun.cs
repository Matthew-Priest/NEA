using UnityEngine;

public class GenerateSun : MonoBehaviour
{
    public float timer;
    public int SpawnCount = 0;
    public GameObject Sun;
    private void Update()
    {
        int rng = Random.Range(10, 17);
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = rng;
            makeSun();
        }
    }
    private void makeSun()
    {
        float range = Random.Range(0f, 14f);
        Vector3 sunspawncoords = new Vector3(range, 0, 1);
        Instantiate(Sun,sunspawncoords,Quaternion.identity);
        Debug.Log("sun made normally");
    }

}
