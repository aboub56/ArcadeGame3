using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public enum playerSelect { player1, player2 };
    public enum inputSelect { horizontal, vertical, power };
    string[,] inputs = new string[2, 3]
    {
        {
            "Horizontal", "Vertical", "Power"
        }
        ,
        {
            "Horizontal2", "Vertical2", "Power2"
        }
    };
    public playerSelect whichPlayer;

    public float speed = 10.0f;
    public Rigidbody player1Rb;
    public GameObject quillPrefab;
    public Transform SpawnPoint;
    public Power currentPower;

    
    void Start()
    {
        Cursor.visible = false;
        player1Rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        QuitGame();
        float forwardInput = Input.GetAxis(inputs[(int)whichPlayer, (int)inputSelect.vertical]);
        player1Rb.AddForce(Vector3.forward * speed *  forwardInput);

        float sideInput = Input.GetAxis(inputs[(int)whichPlayer, (int)inputSelect.horizontal]);
        player1Rb.AddForce(Vector3.right * speed * sideInput);
        if (Input.GetButtonDown("Power2"))
        {
            Debug.Log("Player2 power");
        }

        Debug.Log(Input.GetAxis("Horizontal2"));
            
        if (Input.GetButtonDown(inputs[(int)whichPlayer, (int)inputSelect.power]) && currentPower != null)
        {
            currentPower.usePower();
        }

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }

    }


    public void setPower(Power newPower)
    {
        currentPower = newPower;
    }

    public void QuitGame()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

}
