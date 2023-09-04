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

        // ���콺 ��ġ�� ĳ������ �����ʿ� �ִ��� ���ʿ� �ִ��� Ȯ���մϴ�.
        if (mousePosition.x > transform.position.x)
        {
            // ���콺�� �����ʿ� ������ ĳ���͸� ���������� �ٶ󺸰� �մϴ�.
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            // ���콺�� ���ʿ� ������ ĳ���͸� �������� �ٶ󺸰� �մϴ�.
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
