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
        selectedCharacter = (selectedCharacter + 1) % characters.Length; //배열 범위를 벗어나면 처음 캐릭터로 이동.
        characters[selectedCharacter].SetActive(true);
    }

    public void PreviousCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if(selectedCharacter < 0) //인덱스가 음수면 배열의 마지막 캐릭터로 이동.
        {
            selectedCharacter += characters.Length;
        }
        characters[selectedCharacter].SetActive(true);
    }

    public void StartGame()
    {
        Player.playerNameStr = playerName.text; //입력된 플레이어 이름을 playerNameStr 변수에 저장.
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter); //선택된 캐릭터 인덱스 저장.
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
