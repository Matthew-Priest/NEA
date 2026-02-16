using UnityEngine;
using System.Collections.Generic;



public class Attributes : MonoBehaviour
{
    public static Attributes Instance;   
    public List<string> attributeslist = new List<string>();
    public int AttributeMoney;
    private void Awake() //whole method ensures there are no duplicates of this object and it doesnt get destroyed when player changes scenes. IOT carry attributes over to other levels
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        AttributeMoney = 0;
    }
    public void damageBoost() //ADD PUBLIC TO ALL METHODS THEN ADD ONCLICK FUNC 
    {
        if (!attributeslist.Contains("damageboost") && AttributeMoney >= 5)
        {
            attributeslist.Add("damageboost");
            AttributeMoney -= 5;
        }
        
    }
    public void reduceCooldown() //sunflower
    {
        if (!attributeslist.Contains("reducecooldown") && AttributeMoney >= 5)
        {
            attributeslist.Add("reducecooldown");
            AttributeMoney -= 5;
        }
    }
    public void healthBoost() //all
    {
        if (!attributeslist.Contains("healthboost") && AttributeMoney >= 5)
        {
            attributeslist.Add("healthboost");
            AttributeMoney -= 5;
        }
    }
    public void sunProduction() //made normally not by plant
    {
        if (!attributeslist.Contains("sunproduction") && AttributeMoney >= 5)
        {
            attributeslist.Add("sunproduction");
            AttributeMoney -= 5;
        }
    }
    public void sunBurst() //sunflower ability
    {
        if (!attributeslist.Contains("sunburst") && AttributeMoney >= 5)
        {
            attributeslist.Add("sunburst");
            AttributeMoney -= 5;
        }
    }
    public void slowEnemies() //decrease zombie speed
    {
        if (!attributeslist.Contains("slowenemies") && AttributeMoney >= 5)
        {
            attributeslist.Add("slowenemies");
            AttributeMoney -= 5;
        }
    }
}
