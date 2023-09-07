using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCharacter : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    public Transform spawnPoint;

    private void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter"); //저장된 선택된 캐릭터 인덱스를 가져옴.
        GameObject prefab = characterPrefabs[selectedCharacter]; // 선택된 캐릭터 인덱스를 사용하여 해당 프리팹을 가져옴.
        GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity); // 해당 프리팹을 스폰 포인트의 위치에 복제.

        clone.SetActive(true);
    }
}
