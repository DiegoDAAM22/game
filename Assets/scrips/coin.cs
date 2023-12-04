using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.VFX;

public class coin : MonoBehaviour
{
    public AudioSource coinsound;


    // Start is called before the first frame update
    void Start()
    {
        coinsound = GameObject.Find("coinsound").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * 45 * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            coinsound.Play();


            if (collision.gameObject.tag == "lava")
            {
                Destroy(gameObject);

            }
        }
    }
}
