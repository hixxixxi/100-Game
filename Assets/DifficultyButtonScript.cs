using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyButtonScript : MonoBehaviour
{

    public void easy() {
        TargetGenerator.limit = 1;
    }

    public void medium()
    {
        TargetGenerator.limit = 2;
    }

    public void hard()
    {
        TargetGenerator.limit = 3;
    }
}
