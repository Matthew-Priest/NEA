using Unity.VisualScripting;
using UnityEngine;

public class GenerateSunViaPlant : MonoBehaviour
{
    public GameObject Sun;
    public void makeSunViaPlant(Vector3 position)
    {
        Instantiate(Sun, position, Quaternion.identity);
        Debug.Log("sun made via plant");
    }
}
