using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ninjaStop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
        }
    }
}
