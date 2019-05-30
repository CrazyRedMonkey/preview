using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBuilder 
{
    public GameObject Create(CharactersType characterType, List<WeaponsType> weaponsType)
    {
        CharacterFactory characterFactory = new CharacterFactory();
        WeaponFactory weaponFactory = new WeaponFactory();
        GameObject characterObject = characterFactory.Create(characterType);
        foreach (WeaponsType weaponType in weaponsType)
        {
            GameObject weaponObject = weaponFactory.Create(weaponType);
            weaponObject.transform.SetParent(characterObject.transform, false);
            IWeapon weapon = weaponObject.GetComponent<IWeapon>();
            weapon.BarrelObject = weaponObject.transform.GetChild(0);
        }
        return characterObject;
    }

}
