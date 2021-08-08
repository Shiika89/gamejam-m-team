using UnityEngine;

public class P1win : MonoBehaviour
{

    [SerializeField]
    private float player2_hp = 10;

    [SerializeField]
    GameObject bakuhatu = null;

    [SerializeField]
    GameObject p1_win = null;


    void Update()
    {
        if (player2_hp <= 0)
        {
            if (bakuhatu)
            {
                Instantiate(bakuhatu, this.transform.position, bakuhatu.transform.rotation);
            }
            if (p1_win)
            {
                Instantiate(p1_win, p1_win.transform.position, p1_win.transform.rotation);
            }
            Destroy(this.gameObject);
            
        }

    }
}
