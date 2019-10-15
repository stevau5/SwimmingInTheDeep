using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineMovement : MonoBehaviour
{

    public GameObject player;
    public GameObject minePrefab;
    float moveSpeed = 2f;
    float freq = 5f; 
    float magnitude = 1f;
    Vector3 pos2;

    private int laps = 0;
    void Start(){
        pos2 = transform.position; 
    }


    // Update is called once per frame
    void Update()
    {
        move();


                // Wrap the fish.. 
        if(this.transform.position.x > 18.5f){
            var pos = this.transform.position;
            this.transform.position = new Vector3(-8.4f, pos.y, pos.z);
            pos2 = transform.position; 

            laps++;

            if(laps % 5 == 0 && laps >= 5){
                this.moveSpeed += 2;
            }
        }  

    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            player.GetComponent<PlayerController>().oxygenCylinder--;
        }
    }

    void move(){
        pos2 += transform.right * Time.deltaTime * moveSpeed;
		this.gameObject.transform.position = pos2 + transform.up * Mathf.Sin(Time.time * freq) * magnitude;
    }
}
