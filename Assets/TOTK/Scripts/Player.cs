using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _cameraRoot;
    [SerializeField] private CinemachineFreeLook _playerCam;
    [SerializeField] private PlayerAbilities _playerAbilities;

    private float _camRotationX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateCameraRoot();

        if (Input.GetKeyDown(KeyCode.Q))
        {
            _playerAbilities.ToggleAbility();
        }
    }

    private void LateUpdate()
    {
        _cameraRoot.transform.position = transform.position;
    }

    private void RotateCameraRoot()
    {
        _camRotationX = Input.GetAxis("Mouse X");
        _cameraRoot.transform.Rotate(Vector3.up * _camRotationX, Space.World);     
    }

}
