using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField]
    private float player1_hp = 10;

    [SerializeField]
    private float player2_hp = 10;

    [SerializeField]
    GameObject bakuhatu = null;

    void Update()
    {

        if(player1_hp <= 0 && player2_hp <= 0)
        {
            if (bakuhatu)
            {
                Instantiate(bakuhatu, this.transform.position, bakuhatu.transform.rotation);
            }
            Debug.Log("DRAW");
            Destroy(this.gameObject);
        }
        
        else if (player1_hp <= 0)
        {
            if (bakuhatu)
            {
                Instantiate(bakuhatu, this.transform.position, bakuhatu.transform.rotation);
            }
            Debug.Log("PLAYER2 WIN!");
            Destroy(this.gameObject);

        }

        else if (player2_hp <= 0)
        {
            if (bakuhatu)
            {
                Instantiate(bakuhatu, this.transform.position, bakuhatu.transform.rotation);
            }
            Debug.Log("PLAYER1 WIN!");
            Destroy(this.gameObject);

        }


    }
}
