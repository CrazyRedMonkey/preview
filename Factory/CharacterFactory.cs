using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFactory 
{
    public GameObject Create(CharactersType type)
    {
        GameObject character = Object.Instantiate(Resources.Load<GameObject>("Prefabs/Character" + type.ToString()));
        switch (type)
        {
            case CharactersType.Assasin:
                break;
            case CharactersType.Tank:
                break;
            case CharactersType.Damager:
                break;
        }
        return character;
    }
}
