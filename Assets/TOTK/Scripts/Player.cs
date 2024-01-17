using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _cameraRoot;

    private float _camRotationX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateCameraRoot();
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
