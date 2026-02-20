using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClassicPlantStats : MonoBehaviour
{

    public float maxHealth = 100f;
    public float fireCooldown = 4f;
    public float currentHealth;
    public placePlant removePlant;
    public lvl1Settings lvl1;
    public lvl2Settings lvl2;
    public lvl3Settings lvl3;
    public string sceneName;
    private void Awake()
    {
        sceneName = SceneManager.GetActiveScene().name;
        currentHealth = maxHealth;
        removePlant = Object.FindFirstObjectByType<placePlant>();
        lvl1 = Object.FindFirstObjectByType<lvl1Settings>();
        lvl2 = Object.FindFirstObjectByType<lvl2Settings>();
        lvl3 = Object.FindFirstObjectByType<lvl3Settings>();
    }
    public void takeDamage(int damage)
    {
        //Debug.Log($"{gameObject.name} took {damage} damage");
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            die();
        }
    }
    public void die()
    {       
        Destroy(gameObject);
        removePlant.vectorGameObjectPairs.Remove(transform.position);
    }



}
