using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class waterEnd : MonoBehaviour
{
    [SerializeField] GameObject end;
    // Start is called before the first frame update
    void Start()
    {
        end.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            end.SetActive(true);
            Invoke("Reload", 10f); // wait 1/4 seconds, then reload level
        }
    }
    void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
