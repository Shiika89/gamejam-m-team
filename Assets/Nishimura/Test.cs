using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;

    [SerializeField] GameObject[] re;
    [SerializeField] GameObject[] tagObject;
    [SerializeField] GameObject bom;

    Transform pos;
    [SerializeField] float time = -5f;
    [SerializeField] float timeInterval = 5f;
    [SerializeField] float timeDecrease = 0.5f;
    [SerializeField] float lastTime = 2;
    [SerializeField] int numToGenerate = 1;



    // Start is called before the first frame update
    void Start()
    {

        
        Instantiate(re[Random.Range(0, re.Length)]);

    }

    // Update is called once per frame
    void Update()
    {
        Check("Bomb");

        time += Time.deltaTime;
        if (timeInterval == lastTime && time > timeInterval)
        {
            time = 0;
            if (tagObject.Length < 100) BomGenerater(numToGenerate);
        }
        else if (time > timeInterval)
        {
            time = 0;
            timeInterval -= timeDecrease;
            if (tagObject.Length < 100) BomGenerater(numToGenerate);
        }


    }


    void BomGenerater(int i)
    {
        for (int j = 0; j < i; j++)
        {
            pos = re[Random.Range(0, re.Length)].transform;
            GameObject a = Instantiate(bom, pos);
            audioSource.PlayOneShot(audioClip);

        }
        //tagObject = GameObject.FindGameObjectsWithTag("Bom");
    }

    void Check(string tagName)
    {
        tagObject = GameObject.FindGameObjectsWithTag(tagName);
    }

}
