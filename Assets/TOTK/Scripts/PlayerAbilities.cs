using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilities : MonoBehaviour
{
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
    }

    private void SetCamera()
    {
        Debug.Log(_currentState);
        _abilityAnim.SetInteger("Ability State", (int)_currentState);
    }
}
