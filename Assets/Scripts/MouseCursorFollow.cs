using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MouseCursorFollow : MonoBehaviour
{
    //public float speed = 100f;
    public Rigidbody2D rb;
    private Vector2 mousePosition;

    public Camera mycam;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        rb = GetComponent<Rigidbody2D>();
        mycam = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = mycam.ScreenToWorldPoint(Input.mousePosition);
        rb.MovePosition(mousePosition);
        //transform.position = Vector2.MoveTowards(transform.position, mousePosition, speed * Time.deltaTime);
    }
}
