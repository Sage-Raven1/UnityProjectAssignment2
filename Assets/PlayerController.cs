using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private CharacterInput controls;
    private Vector2 move;

    public float moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake()
    {
        controls = new CharacterInput();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        move = controls.Player.Movement.ReadValue<Vector2>();
        position.y = position.y + move.y * moveSpeed * Time.deltaTime;
        position.x = position.x + move.x * moveSpeed * Time.deltaTime;
        
        transform.position = position;
    }

    private void PlayerMovement()
    {

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
