using UnityEngine;

public class Bird : MonoBehaviour
{
    public float jumpVelocity;
    public AudioSource jumpSound;
    public AudioSource hurtSound;
    Rigidbody2D rigidBody2D;

    private void Awake()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Lose();
    }

    void Jump()
    {
        rigidBody2D.linearVelocity = Vector2.up * jumpVelocity;
        jumpSound.pitch = Random.Range(0.9f, 1.1f);
        jumpSound.Play();
    }

    void Lose()
    {
        hurtSound.Play();
    }
}
