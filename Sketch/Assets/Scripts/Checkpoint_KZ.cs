using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint_KZ: MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;


   void OnTriggerEnter(Collider other)
    {
       player.GetComponent<collisionHandler>().respawnPosition = this.transform.position;
    }
}
