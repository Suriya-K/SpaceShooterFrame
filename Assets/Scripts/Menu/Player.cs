using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bullet;
    public Transform BulletSpawnPoint;
    private float shootCooldown;
    private bool canShoot = false;
    private void Start()
    {
    }
    void Update()
    {
        shootCooldown += Time.deltaTime;
        if (shootCooldown >= 0.2f)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Instantiate(bullet, BulletSpawnPoint.transform.position + BulletSpawnPoint.transform.forward, BulletSpawnPoint.transform.rotation);
                shootCooldown = 0;
            }
        }

    }
}
