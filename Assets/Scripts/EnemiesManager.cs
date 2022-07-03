using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesManager : MonoBehaviour
{
    public Transform[] enemies;

    private void Start()
    {
        enemies = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            enemies[i] = transform.GetChild(i);
            Enemy.EnemiesAlive++;
        }
    }
}
