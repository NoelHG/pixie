using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Directions for use in animations and collider checks.
/// </summary>
public class Direction
{
    readonly string value;
    private Direction(string val) { value = val; }

    public static Direction Up { get { return new Direction("Up"); } }
    public static Direction Down { get { return new Direction("Down"); } }
    public static Direction Left { get { return new Direction("Left"); } }
    public static Direction Right { get { return new Direction("Right"); } }

    /// <summary>
    /// The direction name string, for animations.
    /// </summary>
    public override string ToString()
    {
        return this.value;
    }

    /// <summary>
    /// The direction as a vector2. Used for collider checks.
    /// </summary>
    public Vector2 ToVector2()
    {
        switch (this.value) {
            case "Up":
                return new Vector2(0, 1);
            case "Down":
                return new Vector2(0, -1);
            case "Left":
                return new Vector2(-1, 0);
            case "Right":
                return new Vector2(1, 0);
            default:
                throw new System.ArgumentException("Invalid direction");
        }
    }

    /// <summary>
    /// The amount to move in a single time step.
    /// </summary>
    public Vector2 MovementTimeStep(int speed)
    {
        switch (this.value)
        {
            case "Up":
                return new Vector2(0, speed * Time.deltaTime);
            case "Down":
                return new Vector2(0, -speed * Time.deltaTime);
            case "Left":
                return new Vector2(-speed * Time.deltaTime, 0);
            case "Right":
                return new Vector2(speed * Time.deltaTime, 0);
            default:
                throw new System.ArgumentException("Invalid direction");
        }
    }
}
