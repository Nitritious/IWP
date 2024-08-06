using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrentRounds : MonoBehaviour
{
    public TextMeshProUGUI roundsText;
    void Update()
    {
        roundsText.text = PlayerStats.Rounds.ToString();
    }
}
