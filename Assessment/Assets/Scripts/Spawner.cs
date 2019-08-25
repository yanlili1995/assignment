﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] groups;
    // Start is called before the first frame update
    void Start()
    {
        spawnNext();
    }

    void Update()
    {
        
    }
    public void spawnNext()
    {
         int i = UnityEngine.Random.Range(0, groups.Length);

        Instantiate(groups[i], transform.position,Quaternion.identity);
        
    }

    
}
