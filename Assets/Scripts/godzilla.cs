using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class godzilla : MonoBehaviour
{
    [SerializeField] GameObject god;
    [SerializeField] GameObject godText;
    [SerializeField] GameObject godScript;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            god.SetActive(true); 
            godText.SetActive(true);
            godScript.SetActive(true);
        }
        
    }
}
