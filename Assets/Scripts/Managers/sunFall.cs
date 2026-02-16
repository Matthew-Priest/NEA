using UnityEngine;
using UnityEngine.UIElements;

public class sunFall : MonoBehaviour
{
    static float fallspeed = 1f;
    private float stopY;
    private void Start()
    {
        stopY = Random.Range(-9f, 0);
        transform.position = new Vector3(transform.position.x, transform.position.y, 5);
        Debug.Log(transform.position);
    }
    void Update()
    {
        
        if (transform.position.y > stopY)
        {
            transform.position += Vector3.down * fallspeed * Time.deltaTime;
        }     
    }
}
