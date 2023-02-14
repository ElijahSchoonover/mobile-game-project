using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class CoinCollecting : MonoBehaviour
{
    public int coinCount = 0;
    public int coinsNeeded = 10;
    //public TextMeshProUGUI coinText;
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //coinText.text = $"Coins: {coinCount} / {coinsNeeded}";
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        string otherTag = other.gameObject.tag;
        if (otherTag == "CoinTag")
        {
            coinCount++;
            Destroy(other.gameObject);
        }
        else if (otherTag == "End" && coinCount >= coinsNeeded)
        {
            SceneManager.LoadScene(sceneName);
            Scene activeScene = SceneManager.GetActiveScene();
            switch (activeScene.name)
            {
                case "easy 1":
                        LevelMenu.level1EasyWin = true; break;
                case "easy 2":
                        LevelMenu.level2EasyWin = true; break;
                case "easy 3":
                        LevelMenu.level3EasyWin = true; break;
                case "Hard 1":
                        LevelMenu.level1HardWin = true; break;
                case "Hard 2":
                        LevelMenu.level2HardWin = true; break;
                case "Hard 3":
                        LevelMenu.level3HardWin = true; break;
                case "Hard 4":
                        LevelMenu.level4HardWin = true; break;
                case "Hard 5":
                        LevelMenu.level5HardWin = true; break;
                case "Hard 6":
                        LevelMenu.level6HardWin = true; break;
            }
                
        }
    }
}