using TMPro;
using UnityEngine;

public class displaySun : MonoBehaviour
{
    public TextMeshProUGUI sun_Display;
    public int Sun = 0;

    void Update()
    {
        sun_Display.text = Sun.ToString();
    }
    public void incrementSun(int amt)
    {
        Sun += amt;
    }
}
