using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public int score;
    public int speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collider){
        if(collider.CompareTag("Player")){
            collider.GetComponent<PlayerStats>().score += this.score;
            Debug.Log(collider.GetComponent<PlayerStats>().score);
            Destroy(gameObject);
        }
    }
}
