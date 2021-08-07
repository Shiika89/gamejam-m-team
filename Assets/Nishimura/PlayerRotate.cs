using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    [SerializeField] private float speed;
    Vector2 moveDirection;

    [SerializeField] private GameObject target;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

            this.gameObject.transform.rotation = Quaternion.Euler(0,0,0);

        //var aim = this.target.transform.position - this.transform.position;
        //var look = Quaternion.LookRotation(aim);
        //this.transform.localRotation = look;
    }
}
