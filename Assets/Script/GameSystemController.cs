using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystemController
{
    private static GameSystemController instance;
    private const float PlayerSpeed = 5.0f;
    private const float CameraFPSSpeed = 200.0f;
    
    private GameSystemController()
    {
    }

    public static GameSystemController GetInstance()
    {
        if (instance == null)
        {
            instance = new GameSystemController();
        }
        return instance;
    }
    
    public float GetPlayerSpeed()
    {
        return PlayerSpeed;
    }

    public float GetCameraFPSSpeed()
    {
        return CameraFPSSpeed;
    }
}