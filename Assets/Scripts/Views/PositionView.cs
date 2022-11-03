using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PositionView : MonoBehaviour, IPointerClickHandler
{
    public event EventHandler Clicked;
    public void OnPointerClick(PointerEventData eventData)
    {
        Clicked?.Invoke(this, EventArgs.Empty);

    }

    protected virtual void OnClicked(EventArgs eventArgs)
    {
        var handler = Clicked;
        handler?.Invoke(this, eventArgs);
    }
}
