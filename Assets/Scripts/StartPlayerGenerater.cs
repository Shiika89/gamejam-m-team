using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlayerGenerater : MonoBehaviour
{
    [SerializeField] GameObject[] startPlayerPreset;
    [SerializeField] GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(startPlayerPreset[Random.Range(0, startPlayerPreset.Length)]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
