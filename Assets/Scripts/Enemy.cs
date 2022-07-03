using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameManager manager;
    public AudioSource hitAudio;
    public GameObject enemyDeathEffect;
    public static int EnemiesAlive = 0;
    public float hp = 5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            EnemyDeath();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude > hp)
        {
            EnemyDeath();
        }    
    }

    private void EnemyDeath()
    {
        Instantiate(enemyDeathEffect, transform.position, Quaternion.identity);

        EnemiesAlive--;

        hitAudio.Play();

        ScoreManager.score += 2500;

        manager.GameWon();

        Destroy(gameObject);
    }
}
