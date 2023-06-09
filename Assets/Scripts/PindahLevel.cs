﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahLevel : MonoBehaviour
{
    public int nextSceneLoad;
    void Start()
    {
     nextSceneLoad = SceneManager.GetActiveScene().buildIndex +1;   
    }

    public void OnTriggerEnter2D(Collider2D coll){
        if(coll.gameObject.tag == "Player"){
            SceneManager.LoadScene(4);
            if(nextSceneLoad >PlayerPrefs.GetInt("levelAt")){
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);
            }
        }
    }
}
