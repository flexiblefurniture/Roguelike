using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector2 move;
    public float EnemySpeed;
    static float dead;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
 
    }
    void FixedUpdate()
    {
        move = GameObject.Find("Player").transform.position - transform.position;
        EnemySpeed = EnemySpeed * Mathf.Pow(1.0001f, 0.1f * dead);
        rb.velocity = EnemySpeed * move / Mathf.Sqrt(move.y * move.y + move.x * move.x);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "WeaponTest")
        {
            Destroy(gameObject);
            GameObject killed = GameObject.Find("Killed");
            Score score = killed.GetComponent<Score>();
            score.addScore();
            dead = dead + 1.0f;
        }
    }
}
