using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> 
/// This contains Pixie constants along with reasonable defaults
/// </summary>
public class Constants
{
    /// <summary>
    /// Number of save files the game supports. Optional.
    /// </summary>
    public static int SaveFiles = 7;

    /// <summary>
    /// Number of rooms (scenes) the game supports. Generally best to set to a maximum number you think you'll need.
    /// Useful for creating consistent save files regardless of player progress, and DLCs.
    /// </summary>
    public static int NumberOfRooms = 100;

    /// <summary>
    /// The FPS target for FixedUpdate. Should match the target of Update, generally.
    /// Do Time.fixedDeltaTime = 1f / (Constants.fixedUpdateFPS) in a startup script;
    /// </summary>
    public static int FixedUpdateFPS = 60;
}
