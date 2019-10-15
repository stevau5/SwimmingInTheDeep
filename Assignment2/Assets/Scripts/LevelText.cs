using UnityEngine;
using UnityEngine.UI;

public class LevelText : MonoBehaviour
{
    private int level; 
    public Text levelText; 
    public GameObject fish;
    private int tempLevel;

    // Start is called before the first frame update
    void Start()
    {
        level = 1;
    }

    // Update is called once per frame
    void Update()
    {
        tempLevel = fish.GetComponent<Fish_Swim>().getLevel();
        levelText.text = "Level " + tempLevel;
    }
}
