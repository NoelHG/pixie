using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Represents an object that interacts with the Pixie framework */
public class ActiveObject : MonoBehaviour
{

    SpriteRenderer spriteRenderer;

    /// <summary>
    /// If this is true, the game will automatically choose an offset such that the base of the sprite marks the spot where the layering should switch.
    /// It would be like if the object's lowest Y position is also the bottom of the sprite, with a 0 value for spriteOffset.
    /// This option is very useful if you're lazy, or sprites are centered on the objects. 
    /// Overrides the inputted value for spriteOffset.
    /// </summary>
    [SerializeField] bool autoDetectOffSet;

    /// <summary>
    /// This is the difference between the object's Y position and the intended "bottom". 
    /// 0 is a good value if the object's lowest Y position is also the bottom of the sprite.
    /// </summary>
    [SerializeField] int spriteOffset;


    /// <summary>
    /// Movement speed base. Used with the time step to calculate movement in MovementFrame()
    /// </summary>
    [SerializeField] int movementSpeed = 0;
    //This is changed if using the sprint mechanism
    int currentSpeed;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        if (autoDetectOffSet)
        {
            AutoOffset();
        }

        currentSpeed = movementSpeed;

    }

    void LateUpdate()
    {
        ComputeSortingOrder();
    }

    void ComputeSortingOrder()
    {
        spriteRenderer.sortingOrder = (int)(gameObject.transform.position.y - spriteOffset) * -1;
    }

    void AutoOffset()
    {
        spriteOffset = (int)(gameObject.transform.position.y - Camera.main.WorldToScreenPoint(spriteRenderer.bounds.min).y);
    }


    /// <summary>
    /// Represents what the object will do in a movement timestep.
    /// </summary>
    /// <param name="direction">One of the four directions specified in the Direction class</param>
    void MovementFrame(Direction direction)
    {
        transform.Translate(direction.MovementTimeStep(currentSpeed));
    }
}
