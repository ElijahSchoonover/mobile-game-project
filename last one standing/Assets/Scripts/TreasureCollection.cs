using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class TreasureCollection : MonoBehaviour
{
    public int treasureCount = 0;
    public int treasureNeeded = 1;
    public TextMeshProUGUI treasureText;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //treasureText.text = "Treasure: " + treasureCount;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        string otherTag = other.gameObject.tag;
        if (otherTag == "Treasure")
        {
            treasureCount++;
            Destroy(other.gameObject);
            if (treasureCount >= treasureNeeded)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}
