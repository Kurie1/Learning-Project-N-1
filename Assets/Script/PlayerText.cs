using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script
{
    public class PlayerText : MonoBehaviour
    {
        public TMP_Text PlayerSocre;
        public int Score;
        // Use this for initialization
        public void OnTriggerEnter(Collider other)
        {
            Score += 1;
            PlayerSocre.text = $"{Score}"; 
        }
        
    }
}