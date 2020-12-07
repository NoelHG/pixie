using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Defines a player camera. Attach this to the object to center. TODO - support multiplayer
/// </summary>
public class CameraControl : MonoBehaviour
{

    /// <summary>
    /// This should generally not be used/changed in a 2D game. Any value below 0 should be equivalent.
    /// </summary>
    [SerializeField] float cameraDepth = -1f;

    void Update()
    {
        MoveCamera(transform.position);
    }

    public void MoveCamera(Vector2 target)
    {
        if (target != null)
            Camera.main.transform.position = new Vector3(target.x, target.y, cameraDepth);
        else
            throw new System.ArgumentException("MoveCamera received null target");
    }
}
