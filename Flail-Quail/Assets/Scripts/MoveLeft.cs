using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float movementSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * movementSpeed * Time.deltaTime;
    }
}
