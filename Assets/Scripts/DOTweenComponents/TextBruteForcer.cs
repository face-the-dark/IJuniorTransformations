using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace DOTweenComponents
{
    public class TextBruteForcer : Tweener
    {
        private const float One = 1f;
        
        [SerializeField] private string _replacedText = "Замененный текст. ";
        [SerializeField] private string _addedText = "Добавленный текст";
        [SerializeField] private string _hackedText = "Взломанный текст";
        
        private Text _text;

        private void Awake() =>
            _text = GetComponent<Text>();

        protected override void Tween() =>
            BruteForce();

        private void BruteForce() =>
            DOTween.Sequence()
                .Append(_text.DOText(_replacedText, CalculateDuration()))
                .Append(_text.DOText(_addedText, CalculateDuration()).SetRelative())
                .Append(_text.DOText(_hackedText, CalculateDuration(), true, ScrambleMode.All));

        private float CalculateDuration() => 
            One / StartSpeed;
    }
}