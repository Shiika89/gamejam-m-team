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
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal3");
        float z = Input.GetAxis("Vertical3");

        if ((x != 0) || (z != 0))
        {
            Debug.Log("Con:2 Lstick:" + x + "," + z);
        }

        pos += new Vector2(x * speed, z * speed);
        this.transform.position = pos;

        float x2 = Input.GetAxis("Horizontal4");
        float z2 = Input.GetAxis("Vertical4");

        if ((x2 != 0) || (z2 != 0))
        {
            Debug.Log("Con:2 Rstick:" + x2 + "," + z2);
        }
    }
}
