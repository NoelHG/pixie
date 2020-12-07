using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script should be attached to player character(s). It allows deterministic movement within the game world.
/// </summary>
public class PlayerControl : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey(Keybinds.Interact))
        {
            Interact();
        }

        MovementFrame();
    }

    void Interact()
    {
        //TODO
    }

    void MovementFrame()
    {
        //TODO
    }
}
