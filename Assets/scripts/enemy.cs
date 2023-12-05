using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float EnemySpeed = 5.0f;
    public GameObject[] wayPoints;
    private int currentWayPoint;

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(wayPoints[currentWayPoint].transform.position, transform.position) < .1f)
        
        {
            currentWayPoint++;
            if(currentWayPoint >= wayPoints.Length)
            {
                currentWayPoint = 0;
            }
        }
    }
    transform.position = Vector2.MoveTowards(transform.position, wayPoints[currentWayPoint].transform.position, Time.deltaTime *EnemySpeed);
}
