using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baloon : MonoBehaviour
{
    public int scoreToGive = 1; //skor arttırma 
    public int clicksToPop = 5; //balonun click hakkı
    public float scaleIncreasePerClick = 0.01f; //balonun buyume oranı
    public ScoreManager scoreManager; //scoremanager referans değişkeni

    void OnMouseDown()
    {
        clicksToPop -= 1; //balonun canını bir tane azalt

        transform.localScale += Vector3.one * scaleIncreasePerClick;

        if (clicksToPop == 0)
        {
            scoreManager.IncreaseScore(scoreToGive); //skoru bir tane artırdık
            Destroy(gameObject);
        }
    }
}
