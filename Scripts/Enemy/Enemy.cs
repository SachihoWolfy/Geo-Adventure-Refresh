using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hitpoints = 4;

    void Update()
    {
        if(hitpoints <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
