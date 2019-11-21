using UnityEngine;

namespace RPG.Combat
{
    public class Health : MonoBehaviour
    {
        [SerializeField] float helathPoints = 100.0f;

        bool IsDead = false;

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
            if(IsDead) return;
            IsDead = true;
            GetComponent<Animator>().SetTrigger("die");
        }
    }
    
}