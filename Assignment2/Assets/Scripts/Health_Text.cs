using UnityEngine;
using UnityEngine.UI;

public class Health_Text : MonoBehaviour
{
    public GameObject player;
    public Text health_Text;

    // Update is called once per frame
    void Update()
    {
                health_Text.text = "Oxygen: " + player.GetComponent<PlayerController>().oxygenCylinder; 

    }
}
