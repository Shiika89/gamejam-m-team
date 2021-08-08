using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player2 : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float speed;
    private Vector2 pos;
    private int padIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        pos = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var allGamePads = Gamepad.all;


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
