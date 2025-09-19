using UnityEngine;

[System.Serializable]
public class Entity : MonoBehaviour
{
    public float Health;
    public float Damage;
    public float Speed;
    public void takeDamage(float damage)
    {
        Health = Health - Damage;
        if (Health < 0)
        {
            die();
        }
    }
    public void die()
    {
        Destroy(gameObject);
    }
}
