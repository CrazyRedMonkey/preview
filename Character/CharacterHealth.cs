using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour 
{
    private float health = 30;

    private void OnTriggerEnter(Collider other)
    {
        IProjectile projectile = other.gameObject.GetComponent<IProjectile>();
        if (projectile != null)
        {
            TakeDamage(projectile.Damage);
            Destroy(other.gameObject);
        }
    }

    private void TakeDamage(float damage)
    {
        health -= damage;
        if (health < 0)
            Death();
    }

    private void Death()
    {
        Destroy(gameObject);
    }
}
