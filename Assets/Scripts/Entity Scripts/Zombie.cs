using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Zombie : Entity
{
    void Update()
    {
        transform.Translate(Vector2.left * Speed * Time.deltaTime);
    }
}
