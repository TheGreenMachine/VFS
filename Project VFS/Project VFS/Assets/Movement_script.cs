using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_script : MonoBehaviour
{
    
    int Normal = 4;
    public Transform ball;
 
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


  
    void Regular_movment() {

        targetPostion.z = ball.position.z - 1.2f;
        transform.position = Vector3.MoveTowards(transform.position , targetPostion , Normal * Time.deltaTime);
    }




















}
