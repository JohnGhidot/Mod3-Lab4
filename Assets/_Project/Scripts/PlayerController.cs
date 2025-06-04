using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    Rigidbody2D _rb;
    float h;
    float v;
    [SerializeField] private float Speed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(h, v) * Speed;
        _rb.velocity = movement;
    }

}
