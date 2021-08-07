using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using UnityEngine;

public class Player1Move : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float speed;
    private Vector2 pos;
    //private int player1 = 1;
    // Start is called before the first frame update
    void Start()
    {
        pos = player.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if ((x != 0) || (z != 0))
        {
            Debug.Log("Con1: Lstick:" + x + "," + z);
        }
        pos += new Vector2(x * speed, z * speed);
        transform.position = pos;



        float x2 = Input.GetAxis("Horizontal2");
        float z2 = Input.GetAxis("Vertical2");

        if ((x2 != 0) || (z2 != 0))
        {
            Debug.Log("Con1: Rstick:" + x2 + "," + z2);
        }
    }
}
