using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenSlots : MonoBehaviour
{
    #region Variables
    public bool mouseOver;
    public static bool selected;
    public static bool full;
    #endregion
    private void Start()
    {
    }
    private void Update()
    {

    }
    private void OnMouseOver()
    {
        mouseOver = true;
    }
    private void OnMouseExit()
    {
        mouseOver = false;
    }
}
