using UnityEngine;
using UnityEngine.UI;

public class AttributeBehaviour : MonoBehaviour
{
    public Button damageboost;
    public Button reducecooldown;
    public Button healthboost;
    public Button sunproduction;
    public Button sunburst;
    public Button slowenemies;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        damageboost.onClick.AddListener(() => Attributes.Instance.damageBoost());
        reducecooldown.onClick.AddListener(() => Attributes.Instance.reduceCooldown());
        healthboost.onClick.AddListener(() => Attributes.Instance.healthBoost());
        sunproduction.onClick.AddListener(() => Attributes.Instance.sunProduction());
        sunburst.onClick.AddListener(() => Attributes.Instance.sunBurst());
        slowenemies.onClick.AddListener(() => Attributes.Instance.slowEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
