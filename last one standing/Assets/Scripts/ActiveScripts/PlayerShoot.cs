using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;
    public float speed;
    public float bulletLifeTime = 1.5f;
    public AudioClip shootSound;
    float timer = 0.0f;
    public float shootDelay;
    public int currentAmmo;
    public int maxAmmo;
    public int ammoFoundAmount;
    public TextMeshProUGUI ammoText;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Time.timeScale == 1)
        {
            if (Input.GetButtonDown("Fire1") && timer >= shootDelay && currentAmmo > 0 && !IsMouseOverUI())
            {
                GameObject bulletSpawn = Instantiate(bullet, transform.position, Quaternion.identity);
                Vector3 mousePosition = Input.mousePosition;
                mousePosition.z = -Camera.main.transform.position.z;
                mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
                Vector3 shootDirection = mousePosition - transform.position;
                shootDirection.Normalize();
                bulletSpawn.GetComponent<Rigidbody2D>().velocity = shootDirection * speed;
                Destroy(bulletSpawn, bulletLifeTime);
                GetComponent<AudioSource>().PlayOneShot(shootSound);
                timer = 0;
                currentAmmo--;
                Debug.Log("Successful Shot");

            }
        }
        ammoText.text = $"Ammo: {currentAmmo} / {maxAmmo}";
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        string otherTag = other.gameObject.tag;
        if (otherTag == "Ammo")
        {
            currentAmmo += ammoFoundAmount;
            Destroy(other.gameObject);
            if (currentAmmo > maxAmmo)
            {
                currentAmmo = maxAmmo;
            }
        }
    }
    private bool IsMouseOverUI()
    {
        return EventSystem.current.IsPointerOverGameObject();
    }
}
