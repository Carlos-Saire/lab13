using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoDestroi : MonoBehaviour
{
    public GameObject Explocion;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "ballet")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            GameObject go = Instantiate(Explocion, collision.transform.position, collision.transform.rotation);

            Destroy(go, 0.5f);
        }
    }
}
