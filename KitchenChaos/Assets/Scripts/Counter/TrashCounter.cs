using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TrashCounter : BaseCounter
{
    public static event EventHandler OnAnyObjectTrashed;

    new public static void ResetStaticData()
    {
        OnAnyObjectTrashed = null;
    }

    public override void Interact(Player player)
    {
        if (player.HasKitchenObject()) {
            {
                player.GetKitchenObject().DestrouSelf();

                OnAnyObjectTrashed?.Invoke(this, EventArgs.Empty);
            } }
    }
}
