using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class SpawnNewTreeEvent : UnityEvent<Tree>
{
    private static SpawnNewTreeEvent spawnNewTreeEvent;

    public static SpawnNewTreeEvent Instance
    {
        get
        {
            if (spawnNewTreeEvent == null)
            {
                spawnNewTreeEvent = new SpawnNewTreeEvent();
            }
            return spawnNewTreeEvent;
        }
        private set
        {
            spawnNewTreeEvent = value;
        }
    }
}
