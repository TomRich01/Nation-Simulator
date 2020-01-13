using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nation.Jobs
{
    [CreateAssetMenu(fileName = "Job", menuName = "Nation/Job", order = 0)]
    public class JobScriptObj : ScriptableObject
    {
        public string JobName;

        [Tooltip("Hourly wage")]
        public int averageWage;

        public bool fulltime;
        public bool partime;
        public bool freelance;
        public bool contract;

      

       public void TypeOfJob()
        {
            if (fulltime == true)
            {
                
            }
            if (partime == true)
            {

            }
            if (freelance == true)
            {

            }
            if (contract == true)
            {

            }
        }
    }
}