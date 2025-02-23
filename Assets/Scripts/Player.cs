using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{   
    public Camera cam;
    public NavMeshAgent player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){

            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                player.SetDestination(hit.point);
            }
        }
    }
}
