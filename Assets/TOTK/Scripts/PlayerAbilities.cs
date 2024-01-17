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
    [SerializeField] private Camera _cam;
    [SerializeField] private GameObject _cameraRoot;

    private bool _objectGrabbed = false;

    GrabbableObject _grabbed;

    // Start is called before the first frame update
    void Start()
    {
        _currentState = AbilityState.Normal;
        _selectedAbility = AbilityState.Ultrahand;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q) || Input.GetMouseButtonDown(1))
        {
            ToggleAbility();
        }

        if (Input.GetMouseButtonDown(0))
        {
            UseAbility();
        }
    }

    public void ToggleAbility()
    {
        if (_currentState == _selectedAbility)
        {
            CancelAbility();
            _currentState = AbilityState.Normal;
            _objectGrabbed = false;
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

    private void UseAbility()
    {
        if (!_objectGrabbed)
        {
            switch (_currentState)
            {
                case AbilityState.Normal:
                    break;
                case AbilityState.Ultrahand:
                    UltraHand();
                    break;
                default:
                    break;
            }
        }      
    }

    private void CancelAbility()
    {
        switch (_currentState)
        {
            case AbilityState.Normal:
                break;
            case AbilityState.Ultrahand:
                if (_grabbed != null)
                {
                    _grabbed.UHDrop();
                    _grabbed = null;
                }
                break;
            default:
                break;
        }
    }

    private void UltraHand()
    {
        RaycastHit hit;
        Ray ray = _cam.ScreenPointToRay(Input.mousePosition);
        // generate bitmask to exclude all layers except layer 6 "grabbables"
        int layerMask = 1 << 6;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
        {
            _objectGrabbed = true;
            Transform objectHit = hit.transform;
            GameObject anchorPoint = new GameObject();
            anchorPoint.transform.position = objectHit.transform.position;
            anchorPoint.transform.parent = _cam.transform;
            _grabbed = objectHit.GetComponent<GrabbableObject>();
            _grabbed.UHGrabbed(anchorPoint);
        }
    }
}
