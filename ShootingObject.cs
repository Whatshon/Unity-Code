using UnityEngine;

public class ShootingObject : MonoBehaviour
{
    public GameObject shootinItem;
    public Transform shootingPoint;
    public bool canShoot = true;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            Shoot();
        }

    }

    void Shoot()
    {
        if (!canShoot)
            return;


        GameObject si = Instantiate(shootinItem, shootingPoint);
        si.transform.parent = null;
    }
}
