using UnityEngine;
using TMPro;

public class ChatSystem : MonoBehaviour
{
    public TMP_Text chatText;
    public TMP_InputField messageInput;
    public int maxMessages = 10;

    private void Start()
    {
        messageInput.onEndEdit.AddListener(SubmitMessage);
    }

    private void SubmitMessage(string message)
    {
        if (!string.IsNullOrEmpty(message))
        {
            AddMessage(message);
            messageInput.text = "";
        }
    }

    private void AddMessage(string message)
    {
        string currentText = chatText.text;
        string newMessage = currentText + "\n" + message;

        string[] messages = newMessage.Split('\n');
        if (messages.Length > maxMessages)
        {
            newMessage = string.Join("\n", messages, messages.Length - maxMessages, maxMessages);
        }

        chatText.text = newMessage;
    }
}
