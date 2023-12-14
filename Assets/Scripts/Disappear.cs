using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disappear : MonoBehaviour
{
    public bool isGameActive;
    public GameObject armadillo;
    public GameObject rolypoly;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        isGameActive = true;
        armadillo.gameObject.SetActive(false);
        rolypoly.gameObject.SetActive(false);
    }

}
