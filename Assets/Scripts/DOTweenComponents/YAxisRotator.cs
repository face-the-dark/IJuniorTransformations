using DG.Tweening;
using UnityEngine;

namespace DOTweenComponents
{
    public class YAxisRotator : Tweener
    {
        protected override void Tween() => 
            RotateOnYAxis();

        private void RotateOnYAxis() =>
            transform.DORotate(Vector3.up, StartSpeed)
                .SetSpeedBased(true)
                .SetLoops(LoopsCount, LoopType.Incremental)
                .SetEase(Ease.Linear);
    }
}