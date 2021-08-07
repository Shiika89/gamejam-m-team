using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnime : MonoBehaviour
{
    Animator anime;
    [SerializeField] Animator countanime;
    void Start()
    {
       
        anime = GetComponent<Animator>();
        anime.Play("ugokitomeru");
        countanime.Play("testCountDown");
    }
}
