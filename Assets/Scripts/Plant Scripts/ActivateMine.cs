using UnityEngine.UI;
using UnityEngine;

public class ActivateMine : MonoBehaviour
{
    public float timer = 10f;
    public bool isArmed;

    public Sprite unarmedSprite;
    public Sprite armedSprite;

    public SpriteRenderer m_spriterenderer;
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            m_spriterenderer.sprite = armedSprite;
            isArmed = true;
            transform.localScale = new Vector3(1.1f, 1.1f, 1f);
        }
    }
    private void Awake()
    {
        m_spriterenderer = GetComponent<SpriteRenderer>();
        m_spriterenderer.sprite = unarmedSprite;
        transform.localScale = new Vector3(0.5f, 0.5f, 1f);
        isArmed = false;
    }
}
