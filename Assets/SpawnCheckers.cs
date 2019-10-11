using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCheckers : MonoBehaviour
{

    public Transform Spawn;
    public Transform Spawn2;
    public Transform Spawn3;
    public Transform Spawn4;
    public Transform Spawn5;
    public Transform Spawn6;
    public Transform Spawn7;
    public Transform Spawn8;
    public Transform Spawn9;
    public Transform Spawn10;
    public Transform Spawn11;
    public Transform Spawn12;

    public Transform RedSpawn;
    public Transform RedSpawn2;
    public Transform RedSpawn3;
    public Transform RedSpawn4;
    public Transform RedSpawn5;
    public Transform RedSpawn6;
    public Transform RedSpawn7;
    public Transform RedSpawn8;
    public Transform RedSpawn9;
    public Transform RedSpawn10;
    public Transform RedSpawn11;
    public Transform RedSpawn12;

    public GameObject BlackChecker;
    public GameObject RedChecker;

    public void SpawnCheckersBoard()
    {
        Instantiate(BlackChecker, Spawn);
        Instantiate(BlackChecker, Spawn2);
        Instantiate(BlackChecker, Spawn3);
        Instantiate(BlackChecker, Spawn4);
        Instantiate(BlackChecker, Spawn5);
        Instantiate(BlackChecker, Spawn6);
        Instantiate(BlackChecker, Spawn7);
        Instantiate(BlackChecker, Spawn8);
        Instantiate(BlackChecker, Spawn9);
        Instantiate(BlackChecker, Spawn10);
        Instantiate(BlackChecker, Spawn11);
        Instantiate(BlackChecker, Spawn12);

        Instantiate(RedChecker, RedSpawn);
        Instantiate(RedChecker, RedSpawn2);
        Instantiate(RedChecker, RedSpawn3);
        Instantiate(RedChecker, RedSpawn4);
        Instantiate(RedChecker, RedSpawn5);
        Instantiate(RedChecker, RedSpawn6);
        Instantiate(RedChecker, RedSpawn7);
        Instantiate(RedChecker, RedSpawn8);
        Instantiate(RedChecker, RedSpawn9);
        Instantiate(RedChecker, RedSpawn10);
        Instantiate(RedChecker, RedSpawn11);
        Instantiate(RedChecker, RedSpawn12);


    }
}
