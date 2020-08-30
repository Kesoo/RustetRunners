using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public int healthIncrease;
    public int speed;
    public GameObject pickup;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collider){
        if(collider.CompareTag("Player")){
            Instantiate(pickup, transform.position, Quaternion.identity);
            int playerCurrentHealth = collider.GetComponent<PlayerStats>().health;
            collider.GetComponent<PlayerStats>().health += playerCurrentHealth >= 3 ? 0 : healthIncrease;
            Destroy(gameObject);
        }
    }
}
