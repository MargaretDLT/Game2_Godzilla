using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HELLO : MonoBehaviour
{
    AudioSource MyAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        MyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            MyAudioSource.Play();
        }

    }
}
