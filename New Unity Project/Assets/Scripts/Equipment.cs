using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Equipment : MonoBehaviour
{

    public bool dead = false;

    // Update is called once per frame
    void Update() 
    {
        if (GetComponentInParent<Rigidbody>().isKinematic == true && dead == false)
        {

            Die();
        }

    }
    void Die()
    {
        Debug.Log("Rigid");
        dead = true;
        transform.Rotate(90, 0, 0);
        transform.position -= new Vector3(0, 0.5f, 0);
    }
}
