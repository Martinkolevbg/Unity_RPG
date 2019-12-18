using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using RPG.Saving;


namespace RPG.Cinematics
{
    public class CinematicTrigger : MonoBehaviour, ISaveable
    {
        bool alreadyTriggered = false;

        private void OnTriggerEnter(Collider other) {
            if(!alreadyTriggered && other.gameObject.tag =="Player")
            {
                alreadyTriggered = true;
                GetComponent<PlayableDirector>().Play();
            }
            
        }



        //Saving
        public object CaptureState()
        {
            return alreadyTriggered;
        }

        public void RestoreState(object state)
        {
            state = (bool)alreadyTriggered;
        }

    }
}
