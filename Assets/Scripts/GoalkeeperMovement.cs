using UnityEngine;

public class GoalkeeperMovement : MonoBehaviour
{
    public float speed = 5.0f; // Speed at which the goalkeeper moves
    public float delay = 0.5f; // Delay in seconds before the goalkeeper starts moving towards the ball
    public float distanceThreshold = 1.0f; // Distance threshold from the ball to stop moving towards it

    private GameObject ball; // Reference to the ball object
    private float targetZ; // Z position of the ball that the goalkeeper is currently moving towards
    private bool shouldMove; // Flag to indicate whether the goalkeeper should move towards the ball

    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball"); // Find the ball object by tag
        targetZ = ball.transform.position.z; // Record the initial Z position of the ball
        shouldMove = false; // Don't move towards the ball initially
    }

    void Update()
    {
        // If the goalkeeper should move towards the ball
        if (shouldMove)
        {
            // Move towards the target Z position with a delay
            float z = Mathf.Lerp(transform.position.z, targetZ, speed * Time.deltaTime);
            transform.position = new Vector3(transform.position.x, transform.position.y, z);

            // If the goalkeeper is close enough to the target Z position, stop moving towards the ball
            if (Mathf.Abs(transform.position.z - targetZ) < distanceThreshold)
            {
                shouldMove = false;
            }
        }
        // If the goalkeeper should not move towards the ball
        else
        {
            // If the ball has moved far enough in the Z direction, start moving towards it with a delay
            if (Mathf.Abs(ball.transform.position.z - targetZ) > distanceThreshold)
            {
                Invoke("StartMovingTowardsBall", delay);
            }
        }
    }

    void StartMovingTowardsBall()
    {
        targetZ = ball.transform.position.z; // Update the target Z position of the goalkeeper to the current Z position of the ball
        shouldMove = true; // Set the flag to indicate that the goalkeeper should move towards the ball
    }
}
