using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInput : MonoBehaviour
{
    public Rigidbody2D BodyPlayer;

    private CharacterInput controls;

    public float moveSpeed = 5f;

    private float horizontal;
    private float vertical;

    private Vector2 movement;

    void Start()
    {

    }

    void Awake()

    {
        controls = new CharacterInput();
    }

    void Update()
    {
        horizontal = CharacterInput.GetAxisRaw("X-axis");
        vertical = CharacterInput.GetAxisRaw("Y-axis");
    }

    void FixedUpdate()
    {
        PlayerMovement = new Vector2(horizontal, vertical).normalized;
        BodyPlayer.velocity = new vector2(movement.x * moveSpeed, movement.y) * Time.fixedDeltaTime;
    }

    void OnEnable()

    {
        controls.Enable();   
    }

    void OnDisable()

    {
        controls.Disable();
    }
}
