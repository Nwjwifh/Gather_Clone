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
    public TMP_Text playerName2;

    private SpriteRenderer _spriteRenderer;
    private Color originalColor;

    public GameObject chatCanvas;

    private void Awake()
    {
        playerName.text = playerNameStr;
        playerName2.text = playerNameStr;

        _rigidbody = GetComponent<Rigidbody2D>();

        _spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = _spriteRenderer.color;
    }

    private void FixedUpdate()
    {
            _rigidbody.velocity = _movementInput * _speed;
        
    }

    private void OnMove(InputValue inputValue)
    {
        if (chatCanvas != null && !chatCanvas.activeSelf) // 채팅창이 비활성화된 경우에만 움직임 입력 처리
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
    }

    private void FlipCharacter()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        isFlipped = !isFlipped;
    }

    public void ChangeColorRandom()
    {
        Color randomColor = new Color(Random.value, Random.value, Random.value);
        _spriteRenderer.color = randomColor;
    }

    public void ResetColor()
    {
        _spriteRenderer.color = originalColor;
    }
}
