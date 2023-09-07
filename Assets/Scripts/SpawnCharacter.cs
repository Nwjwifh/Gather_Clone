using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCharacter : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    public Transform spawnPoint;

    private void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter"); //����� ���õ� ĳ���� �ε����� ������.
        GameObject prefab = characterPrefabs[selectedCharacter]; // ���õ� ĳ���� �ε����� ����Ͽ� �ش� �������� ������.
        GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity); // �ش� �������� ���� ����Ʈ�� ��ġ�� ����.

        clone.SetActive(true);
    }
}
