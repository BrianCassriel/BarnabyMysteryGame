using System;
using System.Collections;
using UnityEngine;

public class BarnabyExterior : MonoBehaviour
{
    public BarnabyExterior barnaby;
    public new Camera camera;
    public float moveSpeed = 5f;

    public VectorValue startingPosition;
    // public Animator animator;
    private Rigidbody2D _body2D;
    private Vector2 movement;

    private void Start()
    {
        this._body2D = GetComponent<Rigidbody2D>();
        transform.position = startingPosition.initialValue;
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
        // animator.SetFloat("Horizontal", movement.x);
        // animator.SetFloat("Vertical", movement.y);
        // animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        _body2D.MovePosition(_body2D.position + movement * moveSpeed * Time.fixedDeltaTime);

        if (movement.x > 0)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
        
        if (movement.x < 0)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            MoveFromDoorway(other);
        }
    }

    private void MoveFromDoorway(Collider2D other)
    {
        barnaby.transform.position = other.GetComponent<Doorway>().GetDoorwayLocation();
        camera.transform.position = new Vector3(barnaby.transform.position.x, barnaby.transform.position.y, camera.transform.position.z);
    }
}
