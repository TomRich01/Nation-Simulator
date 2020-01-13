using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Nation.Resource
{
    [CreateAssetMenu(fileName = "Resource", menuName = "Nation/Resource", order = 0)]
    public class Resources : ScriptableObject
{
        public string Name;
        public float PriceToBuy;
        public float PriceToSell;
        public float PriceNow;
    }
}

