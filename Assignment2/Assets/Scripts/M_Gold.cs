using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class M_Gold : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            Debug.Log("Here is some Medium Gold!");
            player.GetComponent<PlayerController>().setScore(2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
