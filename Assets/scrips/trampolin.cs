using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trampolin : MonoBehaviour
{
    public AudioSource boing;

    // Start is called before the first frame update
    void Start()
    {
        boing = GameObject.Find("boing").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject player = collision.gameObject;


            Rigidbody playerrigid =
                player.GetComponent<Rigidbody>();


            Vector3 fuerza = new Vector3(0, 10, 0);
            playerrigid.AddForce(fuerza, ForceMode.Impulse);

            boing.Play(); 

        }
        if (collision.gameObject.tag == "lava")
        {
            Destroy(gameObject);

        }


    }
}
