using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_script : MonoBehaviour
{
    string Difficulty = "Normal";
    int BallFirstBouncePos;
    double Ball_angle;
    double Ball_speed;
    int NumOfBounces;
    double Ballpos;
    double MinDistance = 0;
    double MaxDistance = 23.7744;
    int Fast = 6;
    int Pace = 2;
    int Normal = 4;
    bool Enemyhit;
    public Transform ball;
    public Transform aimTarget;
    Vector3 targetPostion;


    // Start is called before the first frame update
    void Start()
    {
        targetPostion = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        Regular_movment();

    }


  






    void Spike() {
        if (Ball_angle > 80) { 
            
        
        
        
        }
    
    
    }
    void Regular_movment() {

        targetPostion.x = ball.position.x;
        transform.position = Vector3.MoveTowards(transform.position, targetPostion, Normal * Time.deltaTime);
    }




















}
