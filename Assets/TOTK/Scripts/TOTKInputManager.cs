using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TOTKInputManager : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private PlayerAbilities _abilities;

    GameInputs _input;

    // Start is called before the first frame update
    void Start()
    {
        InitializeInputs();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void InitializeInputs()
    {
        _input = new GameInputs();
        _input.ToTK.Enable();

        _input.ToTK.ToggleAbility.performed += ToggleAbility_performed;
        _input.ToTK.UseAbility.performed += UseAbility_performed;
    }

    private void Movement()
    {
        var move = _input.ToTK.Movement.ReadValue<Vector2>();
        _player.Movement(move);
    }

    private void ToggleAbility_performed(InputAction.CallbackContext context)
    {
        _abilities.ToggleAbility();
    }

    private void UseAbility_performed(InputAction.CallbackContext context)
    {
        _abilities.UseAbility();
    }
}
