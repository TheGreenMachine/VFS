using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.IO.Ports;

public class TennisMovement : MonoBehaviour
{
    SerialPort data_stream = new SerialPort("COM5", 115200);
    string RecivedString;
    float conversion = 180 / 3.14f;


    // Use this for initialization
    void Start()
    {

        data_stream.Open();
        data_stream.ReadTimeout = 100;
        data_stream.DtrEnable = true;
    }



    void Update()
    {
        Recive_Input();




    }




    void Recive_Input()
    {
        RecivedString = data_stream.ReadLine();
        string[] receivedvalues = RecivedString.Split(',');
        float accel_x = (float)Convert.ToDouble(receivedvalues[0]);
        float accel_y = (float)Convert.ToDouble(receivedvalues[1]);
        float accel_z = (float)Convert.ToDouble(receivedvalues[2]);

        float gyro_x = (float)Convert.ToDouble(receivedvalues[3]) * Time.deltaTime;
        float gyro_y = (float)Convert.ToDouble(receivedvalues[4]) * Time.deltaTime;
        float gyro_z = (float)Convert.ToDouble(receivedvalues[5]) * Time.deltaTime;


        transform.Rotate(gyro_z * conversion , gyro_x * conversion, -gyro_y * conversion);




    }
    private void OnTriggerEnter(Collider other, float accel_x,float accel_y, float accel_z)
    {
        if (other.CompareTag("Ball"))
        {

            other.GetComponent<Rigidbody>().velocity = new Vector3(accel_x,accel_y,accel_z);

        }

    }



}
