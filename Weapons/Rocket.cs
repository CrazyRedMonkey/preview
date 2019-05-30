using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour , IWeapon
{
    private Transform barrelObject;
    public Transform BarrelObject
    {
        get
        {
            return barrelObject;
        }

        set
        {
            barrelObject = value;
        }
    }

    private IProjectile projectile;
    public IProjectile Projectile
    {
        get
        {
            if (projectile == null)
                projectile = Resources.Load<RocketBullet>("Prefabs/RocketBullet");
            return projectile;
        }
    }

    private float attackSpeed = 1.5f;
    public float AttackSpeed
    {
        get
        {
            return attackSpeed;
        }

        set
        {
            attackSpeed = value;
        }
    }



    private void Start()
    {
        GetComponentInParent<CharacterInput>().OnShoot += Shoot;
    }

    private float nextAviableAttackTime;
    public void Shoot()
    {
        if (Time.time > nextAviableAttackTime)
        {
            Instantiate((RocketBullet)Projectile, barrelObject.transform.position, barrelObject.rotation);
            nextAviableAttackTime = Time.time + AttackSpeed;
        }
    }
}
