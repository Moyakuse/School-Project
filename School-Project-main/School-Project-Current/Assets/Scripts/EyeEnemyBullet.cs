using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeEnemyBullet: MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
