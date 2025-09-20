using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [Header("---- Player Parameters ----")]
    [SerializeField] private float moveSpeed;
    [SerializeField] private Rigidbody rb;

    private Vector2 dir;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        GetInput();
        Movement();
    }

    private void FixedUpdate()
    {

    }

    private void GetInput()
    {
        dir.x = Input.GetAxis("Horizontal");
        dir.y = Input.GetAxis("Vertical");
    }

    private void Movement()
    {
        rb.MovePosition( rb.position + new Vector3(dir.x, 0, dir.y) * moveSpeed * Time.deltaTime);
    }
}
