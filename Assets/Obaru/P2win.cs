using UnityEngine;

public class P2win : MonoBehaviour
{
    [SerializeField]
    private float player1_hp = 10;
   
    [SerializeField]
    GameObject bakuhatu = null;

    [SerializeField]
    GameObject p2_win = null;

    void Update()
    {
        if (player1_hp <= 0)
        {
            if (bakuhatu)
            {
                Instantiate(bakuhatu, this.transform.position, bakuhatu.transform.rotation);
            }
            if (p2_win)
            {
                Instantiate(p2_win, p2_win.transform.position, p2_win.transform.rotation);
            }
            Destroy(this.gameObject);

        }

    }
}
