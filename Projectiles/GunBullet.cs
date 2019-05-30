using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBullet : MonoBehaviour, IProjectile
{
    private float speed = 50;
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

    private float damage = 3;
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

    private float lifeTime = 3;
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
        GetComponent<Rigidbody>().AddForce(transform.forward * Speed, ForceMode.VelocityChange);
    }

    private void Update()
    {
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
            Destroy(gameObject);
    }
}