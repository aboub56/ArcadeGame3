using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    
    public GameObject player1;
    // Start is called before the first frame update
    void Start()
    {
        // Make glove find player
        //player1 = GameObject.Find("Player1");
    }

    // Update is called once per frame
    void Update()
    {
        // Boxing Glove Idea, makes shape stay a certain distant from the player
        //Vector3 lookDirection = (player1.transform.position - transform.position).normalized;

    }
}
