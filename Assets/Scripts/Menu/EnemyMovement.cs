using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform target;
    public Transform child;

    private void Start()
    {
        target = GameObject.Find("Ship").transform;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.LookAt(target);
        transform.Translate(Vector3.forward * 1 * Time.deltaTime);
        child.transform.rotation = Quaternion.Euler(90f, 0.0f, 0.0f);

    }
}
