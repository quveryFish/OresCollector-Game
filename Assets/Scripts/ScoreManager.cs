using System.Threading;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private float timer = 1f;


    [SerializeField] private int score = 0;

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Debug.Log(score);
        }
        timer = 1f;
    }


    public void AddScore(int scoreAmount)
    {
        score += scoreAmount;
    }

    public void RemoveScore(int scoreAmount)
    {
        score -= scoreAmount;
    }



}
