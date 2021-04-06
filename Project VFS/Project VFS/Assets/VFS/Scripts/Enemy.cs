using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform ball;
    public Transform aimTarget;
    public Transform[] targets;
    float force = 13f;
    float speed = 3f;
    Vector3 targetPostion;
    Animator animator;
    int Normal = 4;
    Shot currentShot;
    Shotmanager shotmanager;
    // Start is called before the first frame update
    void Start()
    {
        targetPostion = transform.position;
        animator = GetComponent<Animator>();
        shotmanager = GetComponent<Shotmanager>();
        currentShot = shotmanager.topSpin;
    }

    // Update is called once per frame
    void Update()
    {

        Regular_movment();

    }

    Vector3 PickTarget() {
        int randonValue = Random.Range(0, targets.Length);
        animator = GetComponent<Animator>();
        return targets[randonValue].position;
    
    }

    void Regular_movment()
    {

        targetPostion.z = ball.position.z - 1.2f;
        transform.position = Vector3.MoveTowards(transform.position, targetPostion, Normal * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Ball")) {
            Vector3 dir = aimTarget.position - transform.position;
            other.GetComponent<Rigidbody>().velocity = dir.normalized * currentShot.hitForce + new Vector3(0, currentShot.upForce, 0);

            Vector3 ballDir = ball.position - transform.position;


            if (ballDir.z > 0) {
                animator.Play("Backhand");
            
            }
            if (ballDir.z < 0) {
                animator.Play("Forehand");

            }


        }

    }
}
