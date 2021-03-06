using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public sealed class TimeRemainingController
    {
        #region Fields

        private readonly List<ITimeRemaining> _timeRemainings;

        #endregion

        #region ClassLifeCycles

        public TimeRemainingController()
        {
            _timeRemainings = TimeRemainingExtensions.TimeRemainings;
        }

        #endregion

        #region MyRegion

        public void Execute()
        {
            var time = Time.deltaTime;
            for (int i = 0; i < _timeRemainings.Count; i++)
            {
                var obj = _timeRemainings[i];
                obj.CurrentTime -= time;
                if (obj.CurrentTime <= 0.0f)
                {
                    obj.Method.Invoke();
                    if (!obj.IsRepeating)
                    {
                        obj.RemoveTimeRemaining();
                    }
                    else
                    {
                        obj.CurrentTime = obj.Time;
                    }
                }
            }
        }

        #endregion
        
    }
}