using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FMODBackground : MonoBehaviour
{
private static FMOD.Studio.EventInstance Music;
private static FMOD.Studio.EventInstance Environment;
void Start()
    {
    Music = FMODUnity.RuntimeManager.CreateInstance("event:/Music");
    Music.start();
    Music.release();
    Environment = FMODUnity.RuntimeManager.CreateInstance("event:/Environment");
    Environment.start();
    Environment.release();
    }
}
