using UnityEngine;

public static class SleaseMode
{
    public static GameObject[] obstacle;
    public static bool mode = false;

    public static void sleaseMode()
    {
        if (mode == false)
        {
            mode = true;
            Debug.Log("Mode active!");
        }
        else
        {
            mode = false;
            Debug.Log("Mode deactive!");
        }
    }

    public static void truenOffCollider()
    {
        obstacle = GameObject.FindGameObjectsWithTag("obstacle");
        Debug.Log("Number of obstacles in level: " + obstacle.Length);
        for (int i = 0; i < obstacle.Length; i++)
        {
            obstacle[i].GetComponent<BoxCollider>().enabled = false;
        }
    }
}
