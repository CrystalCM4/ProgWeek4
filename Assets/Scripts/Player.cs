using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace PlayerStuff {
    public class Player : MonoBehaviour
    {   
        public Camera cam;
        public NavMeshAgent player;
        public Animator animator;

        public GameObject enemy;
        private float distance;

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


            //distance between enemy
            distance = Vector3.Distance(enemy.transform.position, transform.position);

            //animate
            if (distance >= 0 && distance <= 5){
                animator.SetBool("Slow", true);
                animator.SetBool("Normal", false);
                animator.SetBool("Fast", false);
            }
            else if (distance >= 5 && distance <= 10){
                animator.SetBool("Slow", false);
                animator.SetBool("Normal", true);
                animator.SetBool("Fast", false);
            }
            else{
                animator.SetBool("Slow", false);
                animator.SetBool("Normal", false);
                animator.SetBool("Fast", true);
            }
            
            

        }

        public void OnCollisionEnter(Collision enemy)
        {
            if (enemy.gameObject.CompareTag("Enemy")){
                print("game over");
            }
        }
    }
}
