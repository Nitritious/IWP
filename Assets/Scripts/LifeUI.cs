using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifeUI : MonoBehaviour
{
    public TextMeshProUGUI livesText;

    private void Update()
    {
        livesText.text = PlayerStats.Lives.ToString();
    }
}
