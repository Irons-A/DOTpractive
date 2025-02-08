using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _targetPosition;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOMove(_targetPosition, _duration)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.Linear);
    }
}
