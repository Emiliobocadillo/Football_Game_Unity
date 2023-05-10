using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed = 2.0f; // Speed at which the obstacle moves
    public float distance = 2.0f; // Distance the obstacle moves from side to side

    private float startPositionZ; // Starting position of the obstacle
    private float direction = 1.0f; // Direction the obstacle is currently moving in

    void Start()
    {
        startPositionZ = transform.position.z; // Record the starting position of the obstacle
    }

    void Update()
    {
        // Move the obstacle in the current direction
        transform.Translate(Vector3.forward * speed * Time.deltaTime * direction);

        // If the obstacle has moved the desired distance in the current direction, change direction
        if (Mathf.Abs(transform.position.z - startPositionZ) >= distance)
        {
            direction *= -1.0f; // Reverse the direction of movement
        }
    }
}
