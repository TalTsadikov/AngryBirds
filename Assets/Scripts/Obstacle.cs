using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float hp = 10f;
    public GameObject obstacleDestroyEffect;
    public AudioSource hitAudio;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude > hp)
        {
            ScoreManager.score += 500;
            DestroyObstacle();
        }
    }

    void DestroyObstacle()
    {
        Instantiate(obstacleDestroyEffect, transform.position, Quaternion.identity);
        hitAudio.Play();
        Destroy(gameObject);
    }
}
