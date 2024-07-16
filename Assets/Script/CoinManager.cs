using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Accessibility;
using Random = UnityEngine.Random;


namespace Assets.Script
{
    public class CoinManager : MonoBehaviour
    {
        public GameObject CoinPrefab;
        public Transform coinManagerTransform;

        public float spawnTime = 0.5f;
        public float startTime = 0;


        private void Update()
        {
            startTime -= Time.deltaTime;

            if (startTime <= 0)
            {
                CoinSpawn();
                startTime = spawnTime;
            }
        }

        private void CoinSpawn()
        {
            var randomX = Random.Range(-5, 5f);
            var randomZ = Random.Range(-5, 5f);

            Vector3 newPosition = new Vector3(randomX, coinManagerTransform.position.y, randomZ);

            GameObject newCoin = Instantiate(CoinPrefab);
            newCoin.transform.position = newPosition;
        }
    }
   
}