using DG.Tweening;
using UnityEngine;

namespace DOTweenComponents
{
    [RequireComponent(typeof(Renderer))]
    public class ColorChanger : Tweener
    {
        private Renderer _renderer;

        private void Awake() => 
            _renderer = GetComponent<Renderer>();

        protected override void Tween() => 
            SetRandomColor();

        private void SetRandomColor() =>
            _renderer.material.DOColor( Random.ColorHSV(), StartSpeed)
                .SetSpeedBased(true)
                .SetLoops(LoopsCount, LoopType.Yoyo)
                .SetEase(Ease.Flash);
    }
}