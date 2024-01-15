using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilities : MonoBehaviour
{
    public delegate void ActivateAbility(int abilityState);
    public static event ActivateAbility activateAbility;

    public enum AbilityState
    {
        Normal,
        Ultrahand
    }

    public AbilityState _currentState { get; private set; }
    public AbilityState _selectedAbility { get; private set; }

    [SerializeField] private Animator _abilityAnim;

    // Start is called before the first frame update
    void Start()
    {
        _currentState = AbilityState.Normal;
        _selectedAbility = AbilityState.Ultrahand;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            ToggleAbility();
        }
    }

    public void ToggleAbility()
    {
        if (_currentState == _selectedAbility)
        {
            _currentState = AbilityState.Normal;
        }
        else
        {
            _currentState = _selectedAbility;
        }

        SetCamera();
        if (activateAbility != null)
        {
            activateAbility((int) _currentState);
        }
    }

    private void SetCamera()
    {
        Debug.Log(_currentState);
        _abilityAnim.SetInteger("Ability State", (int)_currentState);
    }
}
