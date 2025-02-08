using DG.Tweening;
using TMPro;
using UnityEngine;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private float _duration;

    private string _changedText = "Changed text";
    private string _addedText = " Added text";
    private string _overridenText = "Overriden text";

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_changedText, _duration));
        sequence.Append(_text.DOText(_addedText, _duration).SetRelative());
        sequence.Append(_text.DOText(_overridenText, _duration, true, ScrambleMode.All));
        sequence.SetLoops(-1, LoopType.Restart);
    }
}
