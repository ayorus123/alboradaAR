using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoHandler : DefaultTrackableEventHandler
{
    #region PROTECTED_METHODS

    protected override void OnTrackingLost()
    {
        mTrackableBehaviour.GetComponentInChildren<VideoController>().Pause();

        base.OnTrackingLost();
    }

    #endregion // PROTECTED_METHODS
}
