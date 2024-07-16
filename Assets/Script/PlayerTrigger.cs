using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace Assets.Script
{
    public class PlayerTrigger : MonoBehaviour
    {
        public  GameManager modifyScore;

        public void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Coin")
            {
                modifyScore.ModifyScore(+1);
            }
            if (other.tag == "Boom")
            {
                modifyScore.ModifyScore(-1);
            }

            Destroy(other.gameObject);
        }
    }
}