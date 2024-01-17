using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableObject : MonoBehaviour
{
    [SerializeField] private Material _selectedMat;
    [SerializeField] private Material _ultraMat;

    private int _currentAbility = 0;
    private bool _isGrabbed = false;

    private Material _baseMat;
    private MeshRenderer _renderer;
    private GameObject _anchorPoint;
    private Rigidbody _rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
        _baseMat = _renderer.material;
        _rigidBody = GetComponent<Rigidbody>();
        PlayerAbilities.activateAbility += ToggleMat;
    }

    // Update is called once per frame
    void Update()
    {
        if (_isGrabbed)
        {
            MoveToAnchor();
        }
    }

    private void OnMouseEnter()
    {
        if (_currentAbility != 0)
        {
            _renderer.material = _selectedMat;
        }
    }

    private void OnMouseExit()
    {
        if (_currentAbility != 0)
        {
            ToggleMat(_currentAbility);
        }
    }

    private void OnDisable()
    {
        PlayerAbilities.activateAbility -= ToggleMat;
    }

    private void ToggleMat(int abilityState)
    {
        switch (abilityState)
        {
            case 0:
                _renderer.material = _baseMat;
                break;
            case 1:
                _renderer.material = _ultraMat;
                break;
            default:
                break;
        }

        _currentAbility = abilityState;
    }  

    private void MoveToAnchor()
    {
        transform.position = Vector3.Lerp(transform.position, _anchorPoint.transform.position, 0.05f);
        transform.rotation = _anchorPoint.transform.rotation;
    }

    public void UHGrabbed(GameObject anchor)
    {
        _isGrabbed = true;
        _rigidBody.useGravity = false;
        _anchorPoint = anchor;
    }

    public void UHDrop()
    {
        _isGrabbed = false;
        _rigidBody.useGravity = true;
        Destroy(_anchorPoint);
    }
}
