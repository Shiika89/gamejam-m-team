using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using UnityEngine;

public class Player2Move : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float speed;
    private Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if ((x != 0) || (z != 0))
        {
            Debug.Log("stick:" + x + "," + z);
        }

        pos += new Vector2(x * speed, z * speed);
        transform.position = pos;

        if (Input.GetButtonDown("Player2Horizontal"))
        {
            Debug.Log("押された");
        }
    }
}
