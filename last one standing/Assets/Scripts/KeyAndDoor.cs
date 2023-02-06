using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class KeyAndDoor : MonoBehaviour
{
    public int keyCount = 0;
    public string sceneName; 
    public TextMeshProUGUI keyText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        keyText.text = "Keys: " + keyCount;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherTag = collision.gameObject.tag;
        if (otherTag == "Key")
        {
            Destroy(collision.gameObject);
            keyCount++;
        }
        else if (otherTag == "Door" && keyCount > 0)
        {
            Destroy(collision.gameObject);
            keyCount--;
            SceneManager.LoadScene(sceneName);
        }

    }
}
