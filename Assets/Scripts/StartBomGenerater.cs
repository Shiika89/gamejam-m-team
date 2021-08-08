using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBomGenerater : MonoBehaviour
{
    [SerializeField] GameObject[] startBomPreset;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(startBomPreset[Random.Range(0, startBomPreset.Length)]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
