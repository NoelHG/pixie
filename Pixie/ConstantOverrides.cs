using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> 
/// This is used to modify Pixie constants
/// </summary>
public class ConstantOverrides : MonoBehaviour
{
    /// <summary> 
    /// Number of save files the game supports. Optional.
    /// </summary>
    public int SaveFiles = 7;

    /// <summary>
    /// Number of rooms (scenes) the game supports. Generally best to set to a maximum number you think you'll need.
    /// Useful for creating consistent save files regardless of player progress, and DLCs.
    /// </summary>
    public int NumberOfRooms = 100;

    /// <summary>
    /// The FPS target for FixedUpdate. Should match the target of Update, generally.
    /// Do Time.fixedDeltaTime = 1f / (Constants.fixedUpdateFPS) in a startup script;
    /// </summary>
    public int FixedUpdateFPS = 60;

    void Start()
    {
        Constants.SaveFiles = SaveFiles;
        Constants.NumberOfRooms = NumberOfRooms;

        Constants.FixedUpdateFPS = FixedUpdateFPS;
    }
}
