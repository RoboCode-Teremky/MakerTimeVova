using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = ScoreCounter.currentScore;
        //if(ScoreCounter.AddBonus(ScoreText));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
