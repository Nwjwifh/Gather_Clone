using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChatSystem : MonoBehaviour
{
    public TMP_Text chatText;
    public TMP_InputField messageInput;

    private void Start()
    {
        messageInput.onEndEdit.AddListener(SubmitMessage); // ���� Ű�� �����ų� �Է��� ��ġ�� SubmitMessage �޼��� ȣ��.
    }

    private void SubmitMessage(string message) // ����ڰ� �Է��� �޽��� ����.
    {
        if (!string.IsNullOrEmpty(message))
        {
            AddMessage(message);
            messageInput.text = ""; // ��ǲ�ʵ带 ��� �� �޽��� �Է� �����ϰ� ����.
        }
    }

    private void AddMessage(string message) //�� �޽����� ä�� ���뿡 �߰�.
    {
        string currentText = chatText.text;

        // ���� �ؽ�Ʈ�� �� �޽����� ����
        string newMessage = currentText + "\n" + message;

        chatText.text = newMessage;
    }
}
