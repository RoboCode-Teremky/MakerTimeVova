using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    private PlayerInput playerInput;
    private void OnEnable()
    {
        playerInput.Enable();
    }
    private void OnDisable()
    {
        playerInput.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        playerInput.InGame.Movement.started+=ChangeInput;
        playerInput.InGame.Movement.canceled+=ChangeInput;
    }
    private void ChangeInput(InputAction.CallbackContext context){
        Vector2 V = context.ReadValue<Vector2>();
        transform.position = new Vector3(V.x, 0.0f, V.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake(){
        playerInput = new PlayerInput();
    }
}
