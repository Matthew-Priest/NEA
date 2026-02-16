using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class GenerateSunViaPlant : MonoBehaviour
{
    public GameObject Sun;
    public void makeSunViaPlant(Vector3 position)
    {
        Instantiate(Sun, position, Quaternion.identity);
        Debug.Log("sun made via plant");
    }
    public void sunBurst(Vector3 position)
    {
        Instantiate(Sun, position, Quaternion.identity);
        Instantiate(Sun, position, Quaternion.identity);
        Debug.Log("sunburst used");
    }
}
