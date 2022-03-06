using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public bool isDead;
    public float velocity =1f;
    public Rigidbody2D rb2D;
    public GameManager gm;
    public GameObject DeathScr;

    void Start()
    {
        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            rb2D.velocity = Vector2.up * velocity;
        }
    }

   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ScoreArea")
        {
            gm.ScoreUpdate();
        }

    }
   private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Death Area")
        {
            this.isDead = true;
            Debug.Log("son");
            Time.timeScale = 0;
            DeathScr.SetActive(true);
        }

    }


}
