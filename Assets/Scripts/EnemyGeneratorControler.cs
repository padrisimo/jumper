﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneratorControler : MonoBehaviour
{

    public GameObject enemyPrefab;
    public float generatorTimer = 1.75f;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateEnemy()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }

    public void StartGenerator()
    {
        InvokeRepeating("CreateEnemy", 0f, generatorTimer);

    }

    public void CancelGenerator()
    {
        CancelInvoke("CreateEnemy");
    }
}
