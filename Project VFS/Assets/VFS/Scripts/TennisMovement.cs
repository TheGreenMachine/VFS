using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.IO.Ports;

public class TennisMovement : MonoBehaviour
{
   // SerialPort data_stream = new SerialPort("COM7", 9600);
    public string RecivedString;
    public GameObject Ball;
    public float RotationSpeed = 1000;
    public Rigidbody ballRigidbody;

    float force;
   

    float angle = 0;
    // Use this for initialization
    void Start()
    {
                ballRigidbody = Ball.GetComponent<Rigidbody>();
        // data_stream.Open();//initiate the Serial stream

    }



    void Update()
    {
       // Recive_Input();

        

    }


   /* void Recive_Input () {
        RecivedString = data_stream.ReadLine();
        string[] receivedvalues = RecivedString.Split(' ');
        double RacketAngle = Convert.ToDouble(receivedvalues[1]);
        double Racket_X = Convert.ToDouble(receivedvalues[2]);
        double Racket_Y = Convert.ToDouble(receivedvalues[3]);
        
        
        transform.Rotate(0, angle, 0);

    }
   */
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball")) { 
          
               
        }
    }

    void Ball_Prediction() {
       



    }

}
