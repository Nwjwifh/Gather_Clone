using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody2D _rigidbody;
    private Vector2 _movementInput;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = _movementInput * _speed;
    }

    private void OnMove(InputValue inputValue)
    {
        _movementInput = inputValue.Get<Vector2>().normalized;
    }

    private void OnLook(InputValue inputValue)
    {
        Vector2 mousePosition = inputValue.Get<Vector2>();

        // 마우스 위치가 캐릭터의 오른쪽에 있는지 왼쪽에 있는지 확인합니다.
        if (mousePosition.x > transform.position.x)
        {
            // 마우스가 오른쪽에 있으면 캐릭터를 오른쪽으로 바라보게 합니다.
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            // 마우스가 왼쪽에 있으면 캐릭터를 왼쪽으로 바라보게 합니다.
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
