using UnityEngine;

public class CollectSun : MonoBehaviour
{
    public displaySun sunscript; //declares a variable that holds a link to displaySun script currently running on some game object
    void whenClicked()
    {
        Debug.Log("Sun Collected!");
        sunscript.incrementSun(50);
        Destroy(gameObject);
    }
    void Start()
    {
        sunscript = Object.FindFirstObjectByType<displaySun>(); //code used to link something to the script
    }
    void OnMouseDown()
    {
        whenClicked();

    }
}
