﻿public class SNAM16KSet_ObjectBoolean : SNAM_SetDebugGeneric16K<bool>
{
    public override bool GenerateRandomValue()
    {
        return UnityEngine.Random.value > 0.5f;
    }
}
