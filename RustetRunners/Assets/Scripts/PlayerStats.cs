using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public int health;
    public int score;
    private bool incremented;

    // Start is called before the first frame update
    void Start()
    {
        this.score = 0;
        this.incremented = false;
    }

    // Update is called once per frame
    void Update()
    {
        if((int)Time.time % 2 == 0 && !incremented){
            this.score += 1;
            incremented = true;
        } else if((int)Time.time % 2 != 0 && incremented){
            incremented = false;
        }
    }
}
