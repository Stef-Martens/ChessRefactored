using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{

    void Start()
    {
        var positionView = FindObjectOfType<PositionView>();
        positionView.Clicked += PositionViewClicked;
    }

    private void PositionViewClicked(object sender, EventArgs e)
    {
        if (sender is PositionView)
        {

        }
    }
}
