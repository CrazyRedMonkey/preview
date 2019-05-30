using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private void Awake()
    {
        List<CharacterCreationData> data = new List<CharacterCreationData>()
        {
            new CharacterCreationData(){characterType = CharactersType.Damager, weaponsType =  new List<WeaponsType>() { WeaponsType.Winchester,WeaponsType.Rocket}},
            new CharacterCreationData(){characterType = CharactersType.Assasin, weaponsType =  new List<WeaponsType>() { WeaponsType.Winchester}},
            new CharacterCreationData(){characterType = CharactersType.Tank, weaponsType =  new List<WeaponsType>() { WeaponsType.Rocket}},
        };
        CreateCharacters(data);
    }

    private void CreateCharacters(List<CharacterCreationData> data)
    {
        CharacterBuilder builder = new CharacterBuilder();
        foreach (CharacterCreationData obj in data)
        {
            builder.Create(obj.characterType, obj.weaponsType);
        }
    }
}
