using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public TMP_InputField playerName;

    public GameObject[] characters;
    public int selectedCharacter = 0;

    public void NextCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter + 1) % characters.Length; //�迭 ������ ����� ó�� ĳ���ͷ� �̵�.
        characters[selectedCharacter].SetActive(true);
    }

    public void PreviousCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if(selectedCharacter < 0) //�ε����� ������ �迭�� ������ ĳ���ͷ� �̵�.
        {
            selectedCharacter += characters.Length;
        }
        characters[selectedCharacter].SetActive(true);
    }

    public void StartGame()
    {
        Player.playerNameStr = playerName.text; //�Էµ� �÷��̾� �̸��� playerNameStr ������ ����.
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter); //���õ� ĳ���� �ε��� ����.
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
