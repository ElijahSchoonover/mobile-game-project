using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject swarmerPrefab;

    [SerializeField]
    private float swarmerInterval = 5f;

    public float xPosition;
    public float yPosition;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(swarmerInterval, swarmerPrefab));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator spawnEnemy(float interval,  GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(xPosition, yPosition, -1), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
