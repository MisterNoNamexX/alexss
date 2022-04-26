using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    
    public bool dead = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && dead == false)
        {
            Debug.Log("Death");
            GetComponent<Rigidbody>().isKinematic = true;
            
            GetComponent<PlayerMovement>().enabled = false;
            collision.gameObject.GetComponent<Enemy>().enabled = false;
            dead = true;

        }
    }
}
