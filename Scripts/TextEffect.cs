using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(CountdownTimer))]
public class TextEffect : MonoBehaviour
{
    // Start is called before the first frame update
    private CountdownTimer countdownTimer;
    private TextMeshProUGUI textUI;
    int fadeAwayCount = 1;

    private void Awake() {
        
        countdownTimer = GetComponent<CountdownTimer>();
        textUI = GetComponent<TextMeshProUGUI>();        
    }
    void Start()
    {
        countdownTimer.ResetTimer(3);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(fadeAwayCount%2 != 0)
        {
            float alphaRemaining = countdownTimer.GetProportionTimeRemaining();
            fadeAway(alphaRemaining);
            if(alphaRemaining<0f)
            {
                fadeAwayCount += 1;
                Debug.Log("xd");
            }
        }
        else{
            float increaseAlpha = countdownTimer.IncreaseAlpha();
            fadeIn(increaseAlpha);
            if(increaseAlpha>1f)
            {
                fadeAwayCount += 1;
                countdownTimer.ResetTimer(3);
            }
        }
    }

    void fadeAway(float alphaRemaining)
    {
        Color c = textUI.color;
        c.a = alphaRemaining;
        textUI.color = c;
    }

    void fadeIn(float increaseAlpha)
    {
        Color c = textUI.color;
        c.a = increaseAlpha;
        textUI.color = c;
    }
}
