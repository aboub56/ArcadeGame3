using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocalPoint : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        if (transform.position.x < -10)
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        if (transform.position.x > 10)
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
    }
}
