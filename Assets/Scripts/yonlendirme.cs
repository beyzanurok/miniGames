using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yonlendirme : MonoBehaviour
{
    public void LoadBaloonScene()
    {
        SceneManager.LoadScene("Baloon");
    }

    public void LoadBowlingScene()
    {
        SceneManager.LoadScene("Bowling");
    }

    public void LoadLoopsScene()
    {
        SceneManager.LoadScene("Loops");
    }

    public void LoadSimulationScene()
    {
        SceneManager.LoadScene("Simulation");
    }
}
