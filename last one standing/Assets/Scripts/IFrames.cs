
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFrames : MonoBehaviour
{
    Renderer renderer;
    Color color;
    public float iFramesLength;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        color = renderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DamageTag")
        {
            StartCoroutine("GetInvulnerable");
        }
    }
    IEnumerator GetInvulnerable()
    {

        Physics2D.IgnoreLayerCollision(3, 7, true);
        color.a = 0.5f;
        renderer.material.color = color;
        yield return new WaitForSeconds(iFramesLength);
        Physics2D.IgnoreLayerCollision(3, 7, false);
        color.a = 1f;
        renderer.material.color = color;
    }
}