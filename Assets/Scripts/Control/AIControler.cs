using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Control
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] float chaseDistance = 10.0f;
        private void Update()
        {
            
            if(DistanceToPlayer() < chaseDistance)
            {
                print(gameObject.name + "Chase him");
            }
        }

        private float DistanceToPlayer()
        {
            GameObject player = GameObject.FindWithTag("Player");
            return Vector3.Distance(player.transform.position, transform.transform.position);
        }
    }
}
