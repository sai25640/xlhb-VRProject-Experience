using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Angel : MonoBehaviour {

    private Transform m_Transform;

    void Start()
    {
        m_Transform = this.transform;

        Sequence mySequence = DOTween.Sequence();

   
        mySequence.Append(m_Transform.DORotate(new Vector3(0, 0, 0), 2)).SetDelay(2);

        mySequence.Join(m_Transform.DOMoveY(1, 2));

        mySequence.Append(m_Transform.DOLocalMoveZ(5,30).SetEase(Ease.OutSine));

        mySequence.Join(m_Transform.DORotate(new Vector3(20, 0, 0), 1));

        mySequence.Append(m_Transform.DORotate(new Vector3(20, 180, 0), 2));

        mySequence.SetLoops(1);
    }
}
