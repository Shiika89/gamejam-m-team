using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public Gamepad m_gamepad = null;
    [SerializeField] GameObject m_gameManaer;
    [SerializeField] float m_moveSpeed;
    [SerializeField] GameObject m_muzzle;

    public int m_playerNumber = 0; 

    Vector2 m_inputMoveAxis = Vector2.zero;
    Vector2 m_inputMoveAxis2 = Vector2.zero;
    public bool m_fire = false;
    Rigidbody2D m_rb;
    GamePad m_gamePad;

    SpriteRenderer m_mySprite;
    [SerializeField] Sprite[] m_sprite1;
    [SerializeField] Sprite[] m_sprite2;

    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        m_mySprite = GetComponent<SpriteRenderer>();
        m_gamePad = m_gameManaer.GetComponent<GamePad>();

        if (m_playerNumber == 1)
        {
            m_mySprite.sprite = m_sprite2[3];
        }
    }

    // Update is called once per frame
    void Update()
    {
        m_inputMoveAxis = m_gamepad.leftStick.ReadValue();
        m_inputMoveAxis2 = m_gamepad.rightStick.ReadValue();

        m_muzzle.transform.localPosition = m_inputMoveAxis2.normalized * 0.25f;
        m_rb.velocity = m_inputMoveAxis * m_moveSpeed;

        if (m_inputMoveAxis2.x != 0 || m_inputMoveAxis2.y != 0)
        {
            m_fire = true;
        }
        else
        {
            m_fire = false;
        }

        PlayerSprite();
    }

    private void PlayerSprite()
    {
        if (m_playerNumber == 0)
        {
            if (m_inputMoveAxis.x >= 0.7 && m_inputMoveAxis.y <= 0.7)
            {
                if (m_inputMoveAxis.y >= -0.7)
                {
                    m_mySprite.sprite = m_sprite1[0]; //左
                }
            }

            if (m_inputMoveAxis.x <= -0.7 && m_inputMoveAxis.y <= 0.7)
            {
                if (m_inputMoveAxis.y >= -0.7)
                {
                    m_mySprite.sprite = m_sprite1[1]; //右
                }
            }

            if (m_inputMoveAxis.x <= 0.7 && m_inputMoveAxis.y >= 0.7)
            {
                if (m_inputMoveAxis.x >= -0.7)
                {
                    m_mySprite.sprite = m_sprite1[2]; //上
                }
            }

            if (m_inputMoveAxis.x <= 0.7 && m_inputMoveAxis.y <= -0.7)
            {
                if (m_inputMoveAxis.x >= -0.7)
                {
                    m_mySprite.sprite = m_sprite1[3]; //下
                }
            }
        }

        if (m_playerNumber == 1)
        {
            if (m_inputMoveAxis.x >= 0.7 && m_inputMoveAxis.y <= 0.7)
            {
                if (m_inputMoveAxis.y >= -0.7)
                {
                    m_mySprite.sprite = m_sprite2[0]; //左
                }
            }

            if (m_inputMoveAxis.x <= -0.7 && m_inputMoveAxis.y <= 0.7)
            {
                if (m_inputMoveAxis.y >= -0.7)
                {
                    m_mySprite.sprite = m_sprite2[1]; //右
                }
            }

            if (m_inputMoveAxis.x <= 0.7 && m_inputMoveAxis.y >= 0.7)
            {
                if (m_inputMoveAxis.x >= -0.7)
                {
                    m_mySprite.sprite = m_sprite2[2]; //上
                }
            }

            if (m_inputMoveAxis.x <= 0.7 && m_inputMoveAxis.y <= -0.7)
            {
                if (m_inputMoveAxis.x >= -0.7)
                {
                    m_mySprite.sprite = m_sprite2[3]; //下
                }
            }
        }
    }
}
