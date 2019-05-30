using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterEngine : MonoBehaviour
{
    private CharacterInput characterInput;
    private float Speed { get; set; }
    private float RotationSpeed { get; set; }

    private void Awake()
    {
        characterInput = GetComponent<CharacterInput>();
    }

    private void Update()
    {
        transform.position += (Time.deltaTime * characterInput.Vertical * transform.forward * Speed) 
                            + (Time.deltaTime * characterInput.Horizontal * transform.right * Speed);
        
        transform.rotation = Quaternion.Euler(0, transform.eulerAngles.y + Time.deltaTime * characterInput.VisionHorizontal * RotationSpeed, 0);
    }
}
