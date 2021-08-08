using UnityEngine;

public class P1win : MonoBehaviour
{

    Damage m_damage;
    PlayerMove m_playMove;

    [SerializeField]
    private float player2_hp = 10;

    [SerializeField]
    GameObject bakuhatu = null;

    [SerializeField]
    GameObject[] p1_win = null;

    private void Start()
    {
        m_damage = GetComponent<Damage>();
        m_playMove = GetComponent<PlayerMove>();
    }

    void Update()
    {
        if (Damage.hp <= 0)
        {
            if (m_playMove.m_playerNumber == 0)
            {
                Instantiate(p1_win[0], p1_win[0].transform.position, p1_win[0].transform.rotation);
            }
            else
            {
                Instantiate(p1_win[1], p1_win[1].transform.position, p1_win[1].transform.rotation);
            }
        }

    }
}
