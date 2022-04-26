using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{  
    public GameObject wayPoint;
    private Vector3 wayPointPos;
    public float distance;
    [SerializeField] Text DistanceChecker;
    
         //You may consider adding a rigid body to the zombie for accurate physics simulation
    
    //This will be the zombie's speed. Adjust as necessary.
    private float speed = 4.0f;

    void Start()
    {
        //At the start of the game, the zombies will find the gameobject called wayPoint.
        wayPoint = GameObject.Find("wayPoint");
    }

    void Update()
    {
        wayPointPos = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
        //Here, the zombie's will follow the waypoint.
        transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
        distance = Vector3.Distance(transform.position, wayPoint.transform.position);
        DistanceChecker.text = "Distance from enemy: " + distance.ToString("0");
    }


}
