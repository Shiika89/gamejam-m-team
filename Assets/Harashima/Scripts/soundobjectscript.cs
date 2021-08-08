using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundobjectscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("dd",0.8f);
    }

    // Update is called once per frame
    public void dd()
    {
        Destroy(this.gameObject);
    }
}
