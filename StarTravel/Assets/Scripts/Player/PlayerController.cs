using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private FixedJoystick _playerJoystick;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _moveSpeed;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        if (_playerJoystick.Horizontal != 0 || _playerJoystick.Vertical != 0)
            _rb.AddForce(new Vector2(_playerJoystick.Horizontal, _playerJoystick.Vertical) * _moveSpeed * Time.fixedDeltaTime);
    }
}
