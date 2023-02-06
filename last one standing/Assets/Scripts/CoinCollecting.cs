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
    public TextMeshProUGUI coinText;
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = $"Coins: {coinCount} / {coinsNeeded}";
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
        }
    }
}