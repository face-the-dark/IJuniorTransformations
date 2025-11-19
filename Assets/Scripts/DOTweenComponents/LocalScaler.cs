using DG.Tweening;
using UnityEngine;

namespace DOTweenComponents
{
    public class LocalScaler : Tweener
    {
        [SerializeField] private Vector3 _step = new Vector3(0.1f, 0.1f, 0.1f);
        
        protected override void Tween() => 
            EnlargeScale();

        private void EnlargeScale() =>
            transform.DOScale(transform.lossyScale + _step, StartSpeed)
                .SetSpeedBased(true)
                .SetLoops(LoopsCount, LoopType.Incremental)
                .SetEase(Ease.Linear);
    }
}