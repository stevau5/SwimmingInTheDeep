using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldDeposit : MonoBehaviour
{
    public GameObject player;
    private int TempGoldOnPlayer; 

    // Update is called once per frame
    void Update()
    {
        //player.GetComponent<PlayerController>().setCurrentGold(3);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            //if player.getcurrentgold != 0, drop it off by adding to score.. 
            if(player.GetComponent<PlayerController>().getCurrentGold() != 0){
                TempGoldOnPlayer = player.GetComponent<PlayerController>().getCurrentGold();
                player.GetComponent<PlayerController>().setScore(TempGoldOnPlayer);
                player.GetComponent<PlayerController>().moveSpeed = 5f; // reset move speed
                player.GetComponent<PlayerController>().setCurrentGold(0);
            }

        }
    }



}
