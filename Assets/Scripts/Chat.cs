using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChatSystem : MonoBehaviour
{
    public TMP_Text chatText;
    public TMP_InputField messageInput;

    private void Start()
    {
        messageInput.onEndEdit.AddListener(SubmitMessage); // 엔터 키를 누르거나 입력을 마치면 SubmitMessage 메서드 호출.
    }

    private void SubmitMessage(string message) // 사용자가 입력한 메시지 전송.
    {
        if (!string.IsNullOrEmpty(message))
        {
            AddMessage(message);
            messageInput.text = ""; // 인풋필드를 비워 새 메시지 입력 가능하게 설정.
        }
    }

    private void AddMessage(string message) //새 메시지를 채팅 내용에 추가.
    {
        string currentText = chatText.text;

        // 현재 텍스트와 새 메시지를 연결
        string newMessage = currentText + "\n" + message;

        chatText.text = newMessage;
    }
}
