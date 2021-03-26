
using UnityEngine;
using System;

using TMPro;
public class InputField : MonoBehaviour
{
    public static int VremyZarydki;
    public TMP_InputField TMPInputField;

    private void Start()
    {
        TMPInputField.text = "Подкачаться через ... секунд";
        VremyZarydki=5;
    }

    public void EditField()
    {
        VremyZarydki =Convert.ToInt32(TMPInputField.text);
        if (VremyZarydki == 0)
            VremyZarydki = 10;
    }

}
