using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int scoreToGive = 1;
    public int clicksToPop = 5;
    public float scaleIncreasePerClick = 0.1f;
    public scoreManager ScoreManager; //in order to access scoreManager.cs

    void OnMouseDown()
    {
        clicksToPop -= 1;

        transform.localScale += Vector3.one * scaleIncreasePerClick;

        if (clicksToPop == 0)
        {
            ScoreManager.IncreaseScore(scoreToGive); //calling IncreaseScore
            Destroy(gameObject); //Balloon "pops"
        }
    }
}
