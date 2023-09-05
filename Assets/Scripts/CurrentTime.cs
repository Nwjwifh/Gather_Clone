using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class CurrentTime : MonoBehaviour
{
    [SerializeField] TMP_Text currentTime;

    private void Update()
    {
        currentTime.text = DateTime.Now.ToString();
    }
}
