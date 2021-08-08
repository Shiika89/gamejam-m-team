using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class testBombInterval : MonoBehaviour
{
    [SerializeField]GameObject bomb ;
    [SerializeField] GameObject[] Respown;
    [SerializeField] float start_interval = 5;
    float timer;

    void Start()
    {
        int m =Random.Range(0,9);
         Respown[m] = Instantiate(bomb);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        timer += Time.deltaTime;
        if (timer>start_interval)
        {
            timer = 0;
            start_interval -= 0.5f;

        }
    }
}
