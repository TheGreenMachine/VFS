using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.IO.Ports;

public class TennisMovement : MonoBehaviour
{
    SerialPort data_stream = new SerialPort("COM5", 9600);
    string RecivedString;



    // Use this for initialization
    void Start()
    {

        data_stream.Open();

    }



    void Update()
    {

     
            Debug.Log("darriahia");


        
    }

        void Recive_Input() {
            RecivedString = data_stream.ReadLine();
            string[] receivedvalues = RecivedString.Split(',');
            float accel_x = (float)Convert.ToDouble(receivedvalues[0]);
            float accel_y = (float)Convert.ToDouble(receivedvalues[1]);
            float accel_z = (float)Convert.ToDouble(receivedvalues[2]);

            float gyro_x = (float)Convert.ToDouble(receivedvalues[3]);
            float gyro_y = (float)Convert.ToDouble(receivedvalues[4]);
            float gyro_z = (float)Convert.ToDouble(receivedvalues[5]);


            transform.Rotate(gyro_x * 100, gyro_y * 100, gyro_z * 100);
            data_stream.ReadTimeout = 1;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Ball")) {


            }
        }



    } 
