using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("移動速度"), Range(1, 1000)]
    public float speed = 50;
    [Header("跳躍高度"), Range(10, 1000)]
    public float jump = 100;

    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Jump();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rig.AddForce(transform.right * speed * Input.GetAxis("Horizontal"));
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space)) rig.AddForce(transform.up * jump);
    }
}
