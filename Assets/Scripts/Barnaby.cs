using System;
using System.Collections;
using UnityEngine;

public class Barnaby : MonoBehaviour
{
    public new Camera camera;
    public Doorway doorway;
    public float moveSpeed = 5f;

    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _body2D;
    private Vector2 _movement;

    private void Start()
    {
        this._body2D = GetComponent<Rigidbody2D>();
        this._spriteRenderer = GetComponent<SpriteRenderer>();
        transform.position = new Vector3(-41.6f, 21f, 0);
    }

    private void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");
    }
    
    private void FixedUpdate()
    {
        _body2D.MovePosition(_body2D.position + _movement * moveSpeed * Time.fixedDeltaTime);

        if (_movement.x > 0)
        {
            _spriteRenderer.flipX = false;
        }
        if (_movement.x < 0)
        {
            _spriteRenderer.flipX = true;
        }
    }

    public void Warp(Vector4 location)
    {
        transform.position = new Vector3(location.x, location.y, 0);
        camera.transform.position = new Vector3(location.x, location.y, -10);
        camera.orthographicSize = location.w;
        doorway.AutoSetBarnabyScale(location);
    }
}
