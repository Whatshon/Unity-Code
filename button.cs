using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    [SerializeField] private GameObject door1;
    [SerializeField] private GameObject door2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        door1.transform.position += new Vector3(17, -69.6476f, 7.82f);
        door2.transform.position += new Vector3(53, -62.55f, 7.587884f);
    }
    
}
