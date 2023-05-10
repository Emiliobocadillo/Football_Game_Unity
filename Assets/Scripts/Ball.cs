 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private bool stickToPlayer;
    [SerializeField] private Transform transformPlayer;
    [SerializeField] private Transform playerBallPosition;
    float speed;
    Vector3 previousLocation;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!stickToPlayer)
       {
         float distanceToPlayer = Vector3.Distance(transformPlayer.position, transform.position);
         Debug.Log(distanceToPlayer);
         if(distanceToPlayer < 2)
         {
            stickToPlayer = true;
         }
       }
       else
       {
        Vector2 currentLocation = new Vector2(transform.position.x, transform.position.z);
        speed = Vector2.Distance(currentLocation, previousLocation) / Time.deltaTime;
        transform.position = playerBallPosition.position;
        // Debug.DrawLine(transform.position, transform.position + new Vector3(transformPlayer.right.x * 100, 0, transformPlayer.right.z*100), Color.white, 2.5f);
        transform.Rotate(new Vector3(transformPlayer.right.x, 0, transformPlayer.right.z), speed, Space.World);
        previousLocation = currentLocation;
       }

    }
}
