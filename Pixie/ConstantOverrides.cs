using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> 
/// This is used to modify Pixie constants
/// </summary>
public class ConstantOverrides : MonoBehaviour
{
    /// <summary> 
    /// Number of save files the game supports
    /// </summary>
    public int saveFiles = 7;

    /// <summary>
    /// Number of rooms (scenes) the game supports 
    /// </summary>
    public int numberOfRooms = 100;

    /// <summary>
    /// The FPS target for FixedUpdate. Should match the target of Update, generally.
    /// Do Time.fixedDeltaTime = 1f / (Constants.fixedUpdateFPS) in a startup script;
    /// </summary>
    public int fixedUpdateFPS = 60;

    void Start()
    {
        Constants.SaveFiles = saveFiles;
        Constants.NumberOfRooms = numberOfRooms;

        Constants.FixedUpdateFPS = fixedUpdateFPS;
    }
}
