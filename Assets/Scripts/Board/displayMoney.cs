using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class displayMoney : MonoBehaviour
{
    public Attributes Attributes;
    public int money = 0;
    public TMP_Text moneyText;

    private void Start()
    {
        Attributes = Object.FindFirstObjectByType<Attributes>();
        money = Attributes.AttributeMoney;
    }
    private void Update()
    {
        moneyText.text = money.ToString();
    }
}
