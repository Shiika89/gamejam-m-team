using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GamePad : MonoBehaviour
{
    [SerializeField] GameObject m_player;
    public IReadOnlyList<Gamepad> m_allGamepads = Gamepad.all;
    PlayerMove m_playMove;

    // Start is called before the first frame update
    void Start()
    {
        m_playMove = m_player.GetComponent<PlayerMove>();
        m_playMove.m_playerNumber = 0;

        for(int i = 0; i < m_allGamepads.Count; i++)
        {
            GameObject Playerobj = Instantiate(m_player);

            Playerobj.GetComponent<PlayerMove>().m_gamepad = m_allGamepads[i];
            m_playMove.m_playerNumber++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
