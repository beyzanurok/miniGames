using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class Enemy : MonoBehaviour
{
    public GameObject spawnPrefab;
    public int spawnCount = 0;
    public float spawnOffset = 1.5f;
    public TMP_InputField girdi;



    public void SpawnEnemies()
    {
        string userInput = girdi.text;
        //girişi kontrol et
        if (int.TryParse(userInput, out int deneme)) {
            spawnCount = deneme;

            for (int i = 0; i < spawnCount; i++)
            {
                float xPos = i * spawnOffset;
                Vector3 spawnPos = new Vector3(xPos, 0, 0);
                Instantiate(spawnPrefab, spawnPos, Quaternion.identity);
            }
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Main()
    {
        SceneManager.LoadScene("Main");
    }
   
    
}
