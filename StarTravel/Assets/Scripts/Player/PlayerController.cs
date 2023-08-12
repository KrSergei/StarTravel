using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private FixedJoystick _playerJoystick;
    [SerializeField] private CharacterController _playerCC;
    [SerializeField] private float _moveSpeed;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        _playerCC.Move(new Vector2(_playerJoystick.Horizontal * _moveSpeed, _playerJoystick.Vertical * _moveSpeed) * Time.deltaTime);
    }
}
