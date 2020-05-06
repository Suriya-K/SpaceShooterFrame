using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


//
// Credit code by Devster Lp
//

public class FollowPlayer : MonoBehaviour
{

    public Transform target;
    public Vector3 offsetPosition;

    private Space offsetPositionSpace = Space.Self;
    public bool lookAt = true;
    private void Start()
    {

        //offsetPosition = transform.position - target.position;
    }
    void Update()
    {

        /*
        Vector3 newPos = target.position + Offset;
        transform.position = Vector3.Slerp(transform.position, newPos, smoothSpeed);
        */
        if (offsetPositionSpace == Space.Self)
        {
            transform.position = target.TransformPoint(offsetPosition);
        }
        else
        {
            transform.position = target.position + offsetPosition;
        }

        // compute rotation
        if (lookAt)
        {
            transform.LookAt(target);
        }
        else
        {
            transform.rotation = target.rotation;
            /*
            if (transform.rotation.y <= -180)
            {
                transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 0, transform.rotation.eulerAngles.z);
            }
            */
        }
    }
}
