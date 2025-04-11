using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public float rotateSpeed = 360;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotateSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<CoinCollector>().CollectCoin();
            DestroyCoin();
        }
    }

    private void DestroyCoin()
    {
        Destroy(gameObject.GetComponent<Renderer>());
        Destroy(gameObject.GetComponent<Collider>());
        audioSource.Play();
        Destroy(gameObject, 1);
    }
}
