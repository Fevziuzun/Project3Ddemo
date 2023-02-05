using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultInput
{
    private DefaultAction ýnput;

    public bool IsForceUp { get; private set; }

    public DefaultInput()
    {
        ýnput = new DefaultAction();
        ýnput.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton();
        ýnput.Enable();
    }
}