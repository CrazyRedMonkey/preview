using UnityEngine;

public interface IWeapon 
{
    Transform BarrelObject { get; set; }
    IProjectile Projectile { get; }
    float AttackSpeed { get; set; }
    void Shoot();
}
