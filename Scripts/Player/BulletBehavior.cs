using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    [SerializeField] public float speed = 10f; // Speed of the bullet
    [SerializeField] public float distance = 5f; // Distance the bullet can travel before being destroyed
    [SerializeField] public LayerMask whatToHit; // LayerMask to determine what the bullet can collide with

    private Vector2 direction; // Direction the bullet should move in
    private float traveledDistance; // Distance the bullet has traveled so far
    public int damage = 2;

    private void Start()
    {
        // Get the direction the bullet should move in
        if (transform.localScale.x < 0)
        {
            direction = Vector2.left;
        }
        else
        {
            direction = Vector2.right;
        }
    }

    private void Update()
    {
        // Move the bullet in the specified direction
        transform.Translate(direction * speed * Time.deltaTime);

        // Update the traveled distance
        traveledDistance += speed * Time.deltaTime;

        // If the bullet has traveled the specified distance, destroy it
        if (traveledDistance >= distance)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If the bullet collides with something on the whatToHit layer, destroy it
        if (collision.tag.Equals("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
