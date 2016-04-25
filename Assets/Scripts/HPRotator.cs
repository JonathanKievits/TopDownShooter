using UnityEngine;
using System.Collections;

public class HPRotator : MonoBehaviour
{
    public Vector3 rotation;
    public float rotationSpeed;

    void Update()
    {
        transform.Rotate(rotation * rotationSpeed * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}