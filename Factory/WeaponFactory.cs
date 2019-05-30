using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFactory
{
	public GameObject Create (WeaponsType type)
	{
        GameObject weapon = Object.Instantiate(Resources.Load<GameObject>("Prefabs/" + type.ToString())); ;
        switch (type)
        {
            case WeaponsType.Winchester:
                weapon.AddComponent<Winchester>();
                break;
            case WeaponsType.Rocket:
                weapon.AddComponent<Rocket>();
                break;
            default:
                weapon = null;
                break;
        }
        return weapon;
	}
}
