using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text contador;
    public int monedas = 0;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        contador.text = "inicio";
    }

    // Update is called once per frame
    void Update()
    {
        contador.text = ((int)monedas).ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            monedas++;
        }
    }
}
