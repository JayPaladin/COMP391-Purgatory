﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondRespawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            DeadCount.deadCount++;
            GameObject respawnPoint = GameObject.FindGameObjectWithTag("Respawn2");
            GameObject player = GameObject.FindGameObjectWithTag("Player");

            float newX, newY;
            newX = respawnPoint.transform.position.x;
            newY = respawnPoint.transform.position.y;

            player.transform.position = new Vector2(newX, newY);

        }


    }
}