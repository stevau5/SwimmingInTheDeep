using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_Swim : MonoBehaviour
{
    public GameObject player; 
    private int speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position += Vector3.right * speed * Time.deltaTime;

        // Wrap the fish.. 
        if(this.transform.position.x > 8.5f){
            var pos = this.transform.position;
            this.transform.position = new Vector3(-8.4f, pos.y, pos.z);
        }     
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            player.GetComponent<PlayerController>().oxygenCylinder--;
        }
    }
}


//     transform.position += Vector3.down *speed* Time.deltaTime;
