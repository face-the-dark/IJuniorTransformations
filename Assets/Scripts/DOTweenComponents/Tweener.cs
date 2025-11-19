using UnityEngine;

namespace DOTweenComponents
{
    public abstract class Tweener : MonoBehaviour
    {
        [SerializeField] protected float StartSpeed = 1f;
        [SerializeField] protected int LoopsCount = -1;

        private void Start() => 
            Tween();

        protected abstract void Tween();
    }
}