using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultInput
{
    private DefaultAction �nput;

    public bool IsForceUp { get; private set; }

    public DefaultInput()
    {
        �nput = new DefaultAction();
        �nput.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton();
        �nput.Enable();
    }
}