using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoting : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bullet;

    private float bulletForce = 20f;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject Bullet = Instantiate(bullet, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.position * bulletForce, ForceMode2D.Impulse);
    }
}
