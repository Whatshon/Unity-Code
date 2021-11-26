using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour
{
    [SerializeField] private GameObject Door;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Door.transform.position += new Vector3(20, -158.58f, 7.82f);
    }
}
