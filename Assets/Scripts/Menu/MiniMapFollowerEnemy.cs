using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapFollowerEnemy : MonoBehaviour
{
    public Transform target;
    private void Start()
    {
        
    }
    void Update()
    {
        transform.position = new Vector3(target.position.x, 0, target.position.z);
    }
}
