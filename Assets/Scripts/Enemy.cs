using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace EnemyStuff {
    public class Enemy : MonoBehaviour
    {   
        public Camera cam;
        public NavMeshAgent enemy;

        public GameObject player;

        // Update is called once per frame
        void Update()
        {   
            enemy.SetDestination(player.transform.position);

        }
    }
}
