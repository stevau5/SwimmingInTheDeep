using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject player;
    public Text scoreText; 


    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + player.GetComponent<PlayerController>().getScore(); 
    }
}
