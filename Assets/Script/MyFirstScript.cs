using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

namespace Assets.Scripts
{
    public class MyFirstScript : MonoBehaviour
    {
        public int a = 100;
        public int b = 0;
        public int c = 1;
        public int d;

        void Start()
        {
            //float delta = b * b - 4 * a * c;
            //if (delta > 0)
            //{
            //    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            //    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            //    Debug.Log($"Phương trình có 2 nghiệm : {x1}, {x2}");
            //}
            //else if (delta == 0)
            //{
            //    double x = -b / (2 * a);
            //    Debug.Log($"Phương trình có nghiệm kép : {x}");
            //}
            //else
            //{
            //    Debug.Log("Phương trình vô nghiệm");
            //}

            int cur = b;
            int pre = c;

            for (int i = 0; i < a;i++)
            {
               int next = cur + pre;

                if (next > a)
                {
                    break;
                }

                Debug.Log($"{next}");
                cur = pre;
                pre = next;
                
            }


        }
        public int GetSquareRoot(int a)
        {
            for (int i = 0; i <= a; i++)
            {
                if (i * i == a)
                {
                    return i;
                }
            }
            return -1;
        }
        
    }
}