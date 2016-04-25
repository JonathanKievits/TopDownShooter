using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerShooting2 : MonoBehaviour {

    public Projectile projectile;
    public Transform muzzle;
    public Text uiText;
    public float bulletSpeed;
    public float fireRate = 0.3F;
    public float reload = 1.5F;
    private float nextFire = 0.0F;
    private int ammo = 12;
    private bool bReload = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (ammo < 12) {
                ammo = 0;
                bReload = true;
            }
        }
        if (Input.GetButton("Fire2") && Time.time > nextFire)
        {
            if (uiText != null)
            { 
                if (ammo >= 1)
                {
                    nextFire = Time.time + fireRate;
                    Shoot();
                    ammo--;
                }
                else if (ammo == 0)
                {
                    bReload = true;
                }
                uiText.text = "Ammo: "+ ammo + "/ 12".ToString();
            }
        }
        if (bReload == true)
        {
            if (reload > 0)
            {
                reload -= Time.deltaTime;
            }
            if (reload <= 0)
            {
                Reloading();
                bReload = false;
            }
        }
    }

    private void Shoot()
    {
        Projectile newProjectile = Instantiate(projectile, muzzle.position, muzzle.rotation) as Projectile;
        newProjectile.SetSpeed(bulletSpeed);
    }
    private void Reloading()
    {
        if (ammo < 12)
        {
            ammo = 12;
            reload = 1.5F;
            uiText.text = "Ammo: " + ammo + "/ 12".ToString();
        }
    }
}

