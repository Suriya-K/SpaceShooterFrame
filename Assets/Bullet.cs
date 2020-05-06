using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform player;
    void Update()
    {
        transform.position += transform.forward * 1000f * Time.deltaTime;
        if (transform.position.x < -1500 || transform.position.x > 1500 || transform.position.y < -1500 || transform.position.y > 1500 || transform.position.z < -1500 || transform.position.z > 1500)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
