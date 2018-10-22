using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public DebugText _text;
    public ScreenScale _screenScale;
    public UnitychanScale _unitychanScale;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        var frameTimings = new FrameTiming[1];
        FrameTimingManager.CaptureFrameTimings();
        uint numReturened = FrameTimingManager.GetLatestTimings(1, frameTimings);
        var ft = frameTimings[0];

        if(numReturened > 0){
            _text.ft = ft;
        }

        //    Debug.Log( "CPU" + frameTimings[0].cpuFrameTime);

    }
}
