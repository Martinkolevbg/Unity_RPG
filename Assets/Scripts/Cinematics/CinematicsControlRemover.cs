using UnityEngine;
using UnityEngine.Playables;
using RPG.Core;
using RPG.Control;

namespace RPG.Cinematics
{
    public class CinematicsControlRemover : MonoBehaviour 
    {
        GameObject player;

        private void Start() 
        {
            GetComponent<PlayableDirector>().played += DisableControl;
            GetComponent<PlayableDirector>().stopped += EnableControl;
            GameObject player = GameObject.FindWithTag("Player");
        }

        void DisableControl(PlayableDirector dummy)
        {
           player.GetComponent<ActionScheduler>().CancelCurrentAction();
           player.GetComponent<PlayerController>().enabled =false;
        }

        void EnableControl(PlayableDirector dummy)
        {
            player.GetComponent<PlayerController>().enabled = true;
        }
        
    }
}
