using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float Speed = 1f;
    void Update()
    {
        transform.Translate(Vector2.right * Speed * Time.deltaTime);
    }
}
