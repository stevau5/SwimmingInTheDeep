﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenController : MonoBehaviour
{
    public GameObject oxygen;
    public GameObject player;
    public GameObject oxygenPrefab; 
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //GAMEOBJECT.GetComponent<ClassName>().VariableName = 4;


    //check for when player and oxygen bubbles collide so that I can give the player air...
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            Debug.Log("Hey, take some air..");
            player.GetComponent<PlayerController>().air += 25f;

            //@todo
            Destroy(this.gameObject);
            Instantiate(oxygenPrefab, new Vector3(Random.Range(-7.0f, 7.0f), Random.Range(-.3f, -4.5f), transform.position.z), transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 

}
