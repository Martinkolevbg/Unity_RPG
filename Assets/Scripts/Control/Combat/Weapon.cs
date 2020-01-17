using UnityEngine;

namespace RPG.Combat
{
    [CreateAssetMenu(fileName = "Weapon", menuName = "Weapons / Make new Weapon", order = 0)]
    public class Weapon : ScriptableObject
    {
        [SerializeField] AnimatorOverrideController weaponAnimatorOverride = null;
        [SerializeField] GameObject weaponPrefab = null;
        [SerializeField] float weaponDamage = 5f;
        [SerializeField] float weaponRange = 2f;

        public void Spawn(Transform handTransform, Animator animator)
        {
            if(weaponPrefab != null)
            {
                Instantiate(weaponPrefab,handTransform);      
            }
            if(weaponAnimatorOverride != null)
            {
                animator.runtimeAnimatorController = weaponAnimatorOverride;
            }
        }
        public float GetDamage()
        {
            return weaponDamage;
        }
        public float GetRange()
        {
            return weaponRange;
        }
    }
}