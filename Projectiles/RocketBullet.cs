using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBullet : MonoBehaviour, IProjectile
{
    private float speed = 30;
    public float Speed
    {
        get
        {
            return speed;
        }

        set
        {
            speed = value;
        }
    }

    private float damage = 10;
    public float Damage
    {
        get
        {
            return damage;
        }

        set
        {
            damage = value;
        }
    }

    private float lifeTime = 4;
    public float LifeTime
    {
        get
        {
            return lifeTime;
        }

        set
        {
            lifeTime = value;
        }
    }

    private void Awake()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * Speed, ForceMode.Impulse);
    }

    private void Update()
    {
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
            Destroy(gameObject);
    }
}