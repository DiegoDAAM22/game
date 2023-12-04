using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public float speedH;
    public float speedV;
    bool fp = false;
    bool tp = true;
    float yaw;
    float pitch;
    

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fp == true)
        {
            transform.position = new Vector3(player.transform.position.x
            , player.transform.position.y
            , player.transform.position.z);

            yaw -= speedV * Input.GetAxis("Mouse Y");
            pitch += speedH * Input.GetAxis("Mouse X");

            transform.eulerAngles = new Vector3(yaw, pitch, 0.0f);
        }

        if (tp == true)
        {
            transform.position = new Vector3(player.transform.position.x
            , player.transform.position.y + 15f
            , player.transform.position.z);

            transform.eulerAngles = new Vector3(player.transform.rotation.x + 90f
              , player.transform.rotation.y
             , player.transform.rotation.z);
        }

        if (Input.GetKeyDown(KeyCode.CapsLock))
        { fp = !fp;
            tp = !tp;
        }
    }
}
