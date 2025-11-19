using DG.Tweening;
using UnityEngine;

namespace DOTweenComponents
{
    public class ForwardMover : Tweener
    {
        protected override void Tween() => 
            MoveForward();

        private void MoveForward() =>
            transform.DOMove(transform.position + Vector3.forward, StartSpeed)
                .SetSpeedBased(true)
                .SetLoops(LoopsCount, LoopType.Incremental)
                .SetEase(Ease.Linear);
    }
}