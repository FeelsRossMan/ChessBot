using System;
using UnityEngine;
namespace Chess
{
    public class DecimalToBinary : MonoBehaviour
    {
        public static void Convert(string testString) 
        {
            long current = long.Parse(testString);
            string binString = System.Convert.ToString(current, 2);
            
            Debug.Log(binString);
        }
    }
}