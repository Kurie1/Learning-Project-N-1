using System;
using System.Collections;
using System.Threading;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

namespace Assets.Script
{
    public class MyFristScript : MonoBehaviour
    {
        public int Tuoi = 1;

        public float A;
        public float B;
        public float C;
        
        public string Name;

        void Start()
        {
            float Delta;

            Delta = B * B - 4 * A * C;

            float X1;
            float X2;
            

            if (Delta < 0)
            {
                Debug.Log("Vo Nghiem");

            }

            else if (Delta == 0)
            {
                X1=X2=-B/(2*A);

                Debug.Log($"Phuong trinh co nghiem kep {X1},{X2}");

            }

            else
            {
                X1 = ((float)(-B + Math.Sqrt(Delta)))/(2*A);
                X2= ((float)(-B - Math.Sqrt(Delta))) / (2 * A);

                Debug.Log($"Phuong trinh co 2 nghiem {X1},{X2}");
            }
        
        }

       
    }
}