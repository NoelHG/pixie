using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This can be used to change keybinds in both the editor and runtime.
/// </summary>
public class KeybindOverrides : MonoBehaviour
{

    public KeyCode Up = KeyCode.UpArrow;
    public KeyCode Down = KeyCode.DownArrow;
    public KeyCode Left = KeyCode.LeftArrow;
    public KeyCode Right = KeyCode.RightArrow;

    public KeyCode Interact = KeyCode.Space;
    public KeyCode Sprint = KeyCode.LeftShift;

    void Start()
    {
        Keybinds.Up = Up;
        Keybinds.Down = Down;
        Keybinds.Left = Left;
        Keybinds.Right = Right;

        Keybinds.Interact = Interact;
        Keybinds.Sprint = Sprint;

    }
}
