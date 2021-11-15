using UnityEngine;

public class ShootingItem : MonoBehaviour
{
    [SerializeField]private float speed;

    private void Update()
    {
        transform.Translate(transform.right * transform.localScale.x * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            return;
    }
}
