﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MenuSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void normal(){
        SceneManager.LoadScene("MainScene");
    }

    public void special(){
        SceneManager.LoadScene("SpecialScene");
    }



}
