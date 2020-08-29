using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextBehavior : MonoBehaviour
{
    
    public Text scoreText;
    public PlayerStats stats;


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + stats.score;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + stats.score;
    }
}
