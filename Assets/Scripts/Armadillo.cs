using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armadillo : Power
{
    public Rigidbody armadilloRb;
    public float boostSpeed = 5000f;
    public float boostCooldown = 2f;
    public bool boostCooling;
    


    // Start is called before the first frame update
    void Start()
    {
        armadilloRb = GetComponent<Rigidbody>();
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

        if (!boostCooling)
        {
            armadilloRb.AddForce(inputDirection * boostSpeed * Time.deltaTime, ForceMode.Impulse);
            boostCooling = true;
            StartCoroutine(BoostCooldown());
        }

        IEnumerator BoostCooldown()
        {
            yield return new WaitForSeconds(boostCooldown);
            boostCooling = false;
        }
    }
}
    