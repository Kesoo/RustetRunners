using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public int health;
    public int score;
    public GameObject gameOver, gameOverSound;

    private bool incremented;

    // Start is called before the first frame update
    void Start()
    {
        this.score = 0;
        this.incremented = false;
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (health <= 0)
        {
            Instantiate(gameOverSound, transform.position, Quaternion.identity);
            Debug.Log("DEAD");
            gameOver.SetActive(true);
            gameObject.SetActive(false);
        }

        if((int)Time.time % 2 == 0 && !incremented){
            this.score += 1;
            incremented = true;
        } else if((int)Time.time % 2 != 0 && incremented){
            incremented = false;
        }
    }
}
