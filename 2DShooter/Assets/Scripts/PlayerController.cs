using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public sealed class PlayerController : Player
    {
        private void FixedUpdate()
        {
            Move();
        }
    }
}
