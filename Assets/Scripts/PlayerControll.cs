using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControll : MonoBehaviour
{
    PlayerInput playerInput;
    [SerializeField] Transform leftEdge, rightEdge;
    private float relativePosition = 0.5f;
    private float relativeDirection = 0.0f;
    [SerializeField] private float sensitivity = 0.1f;

    private void OnEnable()
    {
        playerInput.Enable();
    }
    private void OnDisable()
    {
        playerInput.Disable();
    }

    private void Awake()
    {
        playerInput = new PlayerInput();
    }
    void Start()
    {
        playerInput.InGame.Movement.started += ChangeDirection;
        playerInput.InGame.Movement.canceled += ChangeDirection;
    }

    void Update()
    {
        relativePosition = Mathf.Clamp(relativePosition += sensitivity*relativeDirection*Time.deltaTime, 0.0f, 1.0f);
        transform.position = Vector3.Lerp(leftEdge.position, rightEdge.position, relativePosition);
    }

    private void ChangeDirection(InputAction.CallbackContext context){
        relativeDirection = context.ReadValue<Vector2>().x;

    }
}
