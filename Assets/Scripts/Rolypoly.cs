using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rolypoly : Power
{

    public Rigidbody rolypolyRb;
    public float armorDuration = 5f;
    public float boostMass = 10f;
    public bool armorActive;
    public bool armorCooldown;

    void Start()
    {
        rolypolyRb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        
    }

    IEnumerator BoostMass(float armorDuration)
    {
        rolypolyRb.mass += boostMass;

        yield return new WaitForSeconds(armorDuration);

        rolypolyRb.mass -= boostMass;
        
        StartCoroutine(ArmorCooldown());
        armorActive = false;
        GetComponent<PlayerController1>().speed = 10.0f;
        armorCooldown = true;
    }

    IEnumerator ArmorCooldown()
    {
        yield return new WaitForSeconds(5);
        armorCooldown = false;
    }

    public override void usePower()
    {
        if (!armorCooldown)
        {
            StartCoroutine(BoostMass(5f));
            armorActive = true;
            GetComponent<PlayerController1>().speed = 50.0f;
        }
    }
}
