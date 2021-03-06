﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextBehavior : MonoBehaviour
{
    
    public Text scoreText;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        scoreText.text = "Score: " + player.GetComponent<PlayerStats>().score;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + player.GetComponent<PlayerStats>().score;
    }
}
