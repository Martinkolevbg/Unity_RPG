using UnityEngine;

namespace RPG.Combat
{
    public class Health : MonoBehaviour
    {
        [SerializeField] float helathPoints = 100.0f;

        bool isDead = false;

        public bool IsDead()
        {
            return isDead;
        }

        public void TakeDamage(float damage)
        {
            helathPoints = Mathf.Max(helathPoints - damage, 0.0f);
            if(helathPoints == 0)
            {
                Die();
            }
        }

        private void Die()
        {
            if(isDead) return;
            isDead = true;
            GetComponent<Animator>().SetTrigger("die");
        }
    }
    
}