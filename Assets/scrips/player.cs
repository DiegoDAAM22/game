using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody fisicaplayer;
    public float speed;
    bool floor = false;
    bool doblesalto = false;
    public AudioSource muerte;
    public int monedas = 0;
    public TMP_Text monedasText;
    public float tiempo;

    // Start is called before the first frame update
    void Start()
    {
      fisicaplayer = GetComponent<Rigidbody>();
        muerte = GameObject.Find("muerte").GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
      float x = Input.GetAxis("Horizontal");
      float y = fisicaplayer.velocity.y;
      float z = Input.GetAxis("Vertical");
    fisicaplayer.velocity = new Vector3(x*speed, y, z*speed);

        if (Input.GetButtonDown("Jump") && floor == true)
        {
            fisicaplayer.AddForce(Vector3.up * 250);
            floor = false; }

        else if (Input.GetButtonDown("Jump") && floor == false && doblesalto == false)
        {
            fisicaplayer.AddForce(Vector3.up * 250);
            doblesalto = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
      if(collision.transform.tag == "floor")
        { floor = true;
            doblesalto = false;
        }

        if (collision.gameObject.tag == "lava")
        { Destroy(gameObject);
            muerte.Play();
            Time.timeScale = 0f;

        }
        if (collision.gameObject.tag == "coin")
        {
            monedas++;
            monedasText.text = monedas.ToString();
        }

    }
}

