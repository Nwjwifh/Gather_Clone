using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody2D _rigidbody;
    private Vector2 _movementInput;

    private bool isFlipped = false;

    public static string playerNameStr;
    public TMP_Text playerName;

    private void Awake()
    {
        playerName.text = playerNameStr;

        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = _movementInput * _speed;
    }

    private void OnMove(InputValue inputValue)
    {
        _movementInput = inputValue.Get<Vector2>().normalized;

        if (_movementInput.x > 0 && isFlipped)
        {
            FlipCharacter();
        }
        else if (_movementInput.x < 0 && !isFlipped)
        {
            FlipCharacter();
        }
    }

    private void FlipCharacter()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        isFlipped = !isFlipped;
    }

}
