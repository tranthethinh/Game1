using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class WinLoseScreen : MonoBehaviour
{
    public TextMeshProUGUI winloseText;
    
    public void Setup(int score){
        gameObject.SetActive(true);
        if (score == 10) {
                Show("YOU WIN");
            }
        else {
            Show("YOU LOSE");
        }
    }
    public void Show (string message){
        
        winloseText.text=message;
        gameObject.SetActive(true);
    }
}
