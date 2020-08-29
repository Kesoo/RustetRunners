using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public int score;
    public int speed;
    public GameObject pickup;

    void Start(){
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        
    }

    void OnTriggerEnter2D(Collider2D collider){
        if(collider.CompareTag("Player")){
            Debug.Log("Play sound effect");
            Instantiate(pickup, transform.position, Quaternion.identity);
            collider.GetComponent<PlayerStats>().score += this.score;
            Destroy(gameObject);
        }
    }
}
