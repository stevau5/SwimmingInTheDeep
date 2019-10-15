using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_Swim : MonoBehaviour
{
    public GameObject player; 
    private int speed = 5;
    private int laps = 0; 
    private int level;

    // Start is called before the first frame update
    void Start()
    {
        level = 1;
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position += Vector3.right * speed * Time.deltaTime;

        // Wrap the fish.. 
        if(this.transform.position.x > 8.5f){
            var pos = this.transform.position;
            this.transform.position = new Vector3(-8.4f, pos.y, pos.z);
            laps++;

            if(laps % 7 == 0 && laps >= 7){
                this.speed += 2;
                level++;
            }
        }     

        
    }

    public int getLevel(){
        return this.level;
    }

    

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            player.GetComponent<PlayerController>().oxygenCylinder--;
        }
    }
}


