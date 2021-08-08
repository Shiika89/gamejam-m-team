using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;

    public void ShoothigScene()
    {
        audioSource.PlayOneShot(audioClip);
        Invoke("Scene", 1f);
    }

    public void Scene()
    {
        SceneManager.LoadScene("Shoothig");
    }

}
