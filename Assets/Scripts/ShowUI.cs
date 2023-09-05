using UnityEngine;

public class ShowUI : MonoBehaviour
{
    public GameObject bellUI;

    public GameObject talkUI;

    private void Start()
    {
        bellUI.SetActive(false);
        talkUI.SetActive(false);
    }

    private void Update()
    {
        if (talkUI.activeSelf)
        {
            bellUI.SetActive(false);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            bellUI.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            bellUI.SetActive(false);
        }
    }

    public void ShowDialogue()
    {
        bellUI.SetActive(false);
        talkUI.SetActive(true);
    }

    public void EndDialogue()
    {
        talkUI.SetActive(false);
    }
}
