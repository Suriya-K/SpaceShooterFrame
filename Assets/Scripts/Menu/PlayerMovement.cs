//
// Copyright (c) Brian Hernandez. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for details.
//

using UnityEngine;

/// <summary>
/// Class specifically to deal with input.
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [Range(-10f, 100f)]
    public float acceleration;
    public Vector3 rotation;
    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        setAcceleration();
        movement();
        moveObject(0, 0, acceleration);
    }

    void setAcceleration()
    {
        if (Input.GetKey(KeyCode.R))
        {
            acceleration += 1f;
        }
        if (Input.GetKey(KeyCode.F))
        {
            acceleration -= 1f;
        }
        if (acceleration > 100f)
        {
            acceleration = 100f;
        }
        if (acceleration <= -10f)
        {
            acceleration = -10f;
        }
    }

    void movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rotateObject(rotation.x, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rotateObject(0, -rotation.y, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rotateObject(-rotation.x, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rotateObject(0, rotation.y, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rotateObject(0, 0, rotation.z);
        }
        if (Input.GetKey(KeyCode.E))
        {
            rotateObject(0, 0, -rotation.z);
        }
    }

    void moveObject(float x = 0, float y = 0, float z = 0)
    {
        rb.AddRelativeForce(x, y, z);
    }
    void rotateObject(float x = 0, float y = 0, float z = 0)
    {
        rb.AddRelativeTorque(x, y, z);
    }
}