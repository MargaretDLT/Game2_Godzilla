using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class godzillaPlay : MonoBehaviour
{
    AudioSource rock;

    // Start is called before the first frame update
    void Start()
    {
        rock = GetComponent<AudioSource>();
        rock.Play();
    }

   
}
