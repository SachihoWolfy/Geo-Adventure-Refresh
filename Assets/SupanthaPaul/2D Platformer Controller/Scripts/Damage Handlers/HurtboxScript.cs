using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtboxScript : MonoBehaviour
{
    public Enemy parentEnemy;

    void OnTriggerEnter2D(Collider2D collided)
    {
        BulletBehavior collidedScript = collided.gameObject.GetComponent<BulletBehavior>();
        parentEnemy.hitpoints -= collidedScript.damage;
        Destroy(collided.gameObject);
    }
}
