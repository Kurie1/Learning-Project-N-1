using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Accessibility;
using Random = UnityEngine.Random;


namespace Assets.Script
{
    public class SpawnManager : MonoBehaviour
    {
        public GameObject CoinPrefab;
        public GameObject BoomPrefab;
        public Transform coinManagerTransform;

        public float spawnTime = 0.5f;
        public float startTime = 0;
        public float percent;

        private void Update()
        {
            startTime -= Time.deltaTime;

            if (startTime <= 0)
            {
                Spawner();
                startTime = spawnTime;
            }
        }

        private void Spawner()
        {
            float randomX = Random.Range(-5, 5f);
            float randomZ = Random.Range(-5, 5f);
            float randomPercent = Random.Range(0, 1f);

            Vector3 newPosition = new Vector3(randomX, coinManagerTransform.position.y, randomZ);

            if (randomPercent < percent)
            {
                GameObject newCoin = Instantiate(CoinPrefab);
                newCoin.transform.position = newPosition;
            }
            else
            {
                GameObject newBoom = Instantiate(BoomPrefab);
                newBoom.transform.position = newPosition;
            }
        }
       
    }
   
}