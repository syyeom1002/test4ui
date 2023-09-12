using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationReceiver : MonoBehaviour
{
    public System.Action OnFinished;
    public void onFinished()
    {
        Debug.Log("animation finished");
        if (this.OnFinished != null)
            this.OnFinished();
    }
}
