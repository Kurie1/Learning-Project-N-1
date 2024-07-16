using System.Collections;
using TMPro;
using UnityEngine;

namespace Assets.Script
{
    public class GameManager : MonoBehaviour
    {
        public int Point;
        public TMP_Text PlayerScore;
        public TMP_Text EndGameUI;
        public SpawnManager Spawner;

        private void Start()
        {
            EndGameUI.gameObject.SetActive(false);
        }
        private void Update()
        {
            if (Point >= 100)
            {
                EndGameUI.text = " You Win";
                EndGameUI.gameObject.SetActive(true);
                Spawner.gameObject.SetActive(false);
            }
            if (Point <= -50)
            {
                EndGameUI.text = " You Lose";
                EndGameUI.gameObject.SetActive(true);
                Spawner.gameObject.SetActive(false);
            }
        }
        // Use this for initialization
        public void playerScore(int Score)
        {
            Point = Score;
            PlayerScore.text = $"{Score}";

        }
        public void ModifyScore(int delta)
        {
            playerScore(Point + delta);
        }
      
    }
}