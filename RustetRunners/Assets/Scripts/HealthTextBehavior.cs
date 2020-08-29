using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthTextBehavior : MonoBehaviour
{
    
    public Text healthText;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        healthText.text = "Health: " + player.GetComponent<PlayerStats>().health;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + player.GetComponent<PlayerStats>().health;
    }
}
