using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hedgehog : Power
{
    public Rigidbody hedgehogRb;
    public GameObject quillPrefab;
    public GameObject focalPoint;
    public Transform SpawnPoint;
    public float quillCooldown = 5.0f;
    public bool quillActive;
    // Start is called before the first frame update
    void Start()
    {
        hedgehogRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    public override void usePower()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 inputDirection = new Vector3(horizontalInput, 0, verticalInput);
        //Vector3 lookDirection = (hedgehogRb.transform.position - transform.position).normalized;

        GameObject Quill = quillPrefab;




        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Quill, SpawnPoint.position, Quill.transform.rotation);
        }

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }

    //Old movement
    //float forwardInput = Input.GetAxis("Vertical");

    // if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
    //{
    //hedgehogRb.AddForce(Vector3.right * speed * forwardInput);
    //}


    //float sideInput = Input.GetAxis("Horizontal");
    //hedgehogRb.AddForce(Vector3.forward * speed * sideInput);


}
