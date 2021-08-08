using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GamePad : MonoBehaviour
{
    [SerializeField] GameObject m_player;

    // Start is called before the first frame update
    void Start()
    {
        var allGamepads = Gamepad.all;

        for (int i = 0; i < allGamepads.Count; i++)
        {
            GameObject Playerobj = Instantiate(m_player);

            Playerobj.GetComponent<PlayerMove>().m_gamepad = allGamepads[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
