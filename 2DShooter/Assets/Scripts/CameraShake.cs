using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public sealed class CameraShake : MonoBehaviour
    {
        public Animator camShake;

        public void Shake()
        {
            camShake.SetTrigger("shake");
        }
    }
}

