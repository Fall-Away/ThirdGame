using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour //����ģ �ڵ�
{
    [Header("SpawnTime")]
    [SerializeField] int slowslow = 3;
    [SerializeField] int slow = 2;
    [SerializeField] int fast = 1;


    private float _time = 0;

    #region �ѹ� ������ ���Ѱ�
    private bool one = false;
    private bool two = false;
    private bool three = false;
    private bool four = false;
    private bool five = false;
    private bool six = false;
    private bool seven = false;
    private bool eight = false;
    private bool nine = false;
    private bool ten = false;
    #endregion

    #region Enemys
    private EnemySpawner left_Enemy;
    private EnemySpawner right_Enemy;

    private EnemySpawner left_fly_Enemy;
    private EnemySpawner right_fly_Enemy;

    private EnemySpawner left_Boss;
    #endregion

    private void Awake()
    {
   
        #region Enemys
        left_Enemy = GameObject.Find("Left_Enemy").GetComponent<EnemySpawner>();
        right_Enemy = GameObject.Find("Right_Enemy").GetComponent<EnemySpawner>();
        
        left_fly_Enemy = GameObject.Find("Left_Fly_Enemy").GetComponent<EnemySpawner>();
        right_fly_Enemy = GameObject.Find("Right_Fly_Enemy").GetComponent<EnemySpawner>();

        left_Boss = GameObject.Find("Left_Boss").GetComponent<EnemySpawner>();
        #endregion
    }

    private void Update()
    {
       
         _time = Time.time;
        #region �Լ� ���ۿ� ��ũ��Ʈ
        if (_time < 60 && one == false)
            Spawn1();
        if (60 < _time && _time < 120 && two == false)
            Spawn2();
        if (120 < _time && _time < 180 && three == false)
            Spawn3();
        if (180 < _time && _time < 240 && four == false)
            Spawn4();
        if (240 < _time && _time < 300 && five == false)
            Spawn5();
        if (300 < _time && _time < 360 && six == false)
            Spawn6();
        if (360 < _time && _time < 420 && seven == false)
            Spawn7();
        if (420 < _time && _time < 480 && eight == false)
            Spawn8();
        if (480 < _time && _time < 540 && nine == false)
            Spawn9();
        if (540 < _time && _time < 600 && ten == false)
            Spawn10();
        #endregion
    }

    #region ���ܿ� �Լ���
    private void Spawn1()
    {
        left_Enemy.StartSpawn(slowslow);
        one = true;
    }

    private void Spawn2()
    {
        left_Enemy.StartSpawn(slowslow);
        right_Enemy.StartSpawn(slowslow);
        two = true;
    }
    
    private void Spawn3()
    {
        left_Enemy.StartSpawn(slow);
        right_Enemy.StartSpawn(slow);

        three = true;
    }
    
    private void Spawn4()
    {
        left_Enemy.StartSpawn(slowslow);
        right_Enemy.StartSpawn(slowslow);

        left_fly_Enemy.StartSpawn(slowslow);
        right_fly_Enemy.StartSpawn(slowslow);

        four = true;
    }
    
    private void Spawn5()
    {
        left_Enemy.StartSpawn(slow);
        right_Enemy.StartSpawn(slow);

        left_fly_Enemy.StartSpawn(slow);
        right_fly_Enemy.StartSpawn(slow);

        five = true;
    }
    
    private void Spawn6()
    {
        left_Enemy.StartSpawn(fast);
        right_Enemy.StartSpawn(fast);

        left_fly_Enemy.StartSpawn(slow);
        right_fly_Enemy.StartSpawn(slow);

        six = true;
    }
    
    private void Spawn7()
    {
        left_Enemy.StartSpawn(fast);
        right_Enemy.StartSpawn(fast);

        left_fly_Enemy.StartSpawn(slow);
        right_fly_Enemy.StartSpawn(slow);

        seven = true;
    }
    
    private void Spawn8()
    {
        left_Enemy.StartSpawn(fast);
        right_Enemy.StartSpawn(fast);

        left_fly_Enemy.StartSpawn(slow);
        right_fly_Enemy.StartSpawn(slow);

        eight = true;
    }
    
    private void Spawn9()
    {
        left_Enemy.StartSpawn(fast);
        right_Enemy.StartSpawn(fast);

        left_fly_Enemy.StartSpawn(fast);
        right_fly_Enemy.StartSpawn(fast);

        nine = true;
    }
    
    private void Spawn10()
    {
        left_Enemy.StartSpawn(fast);
        right_Enemy.StartSpawn(fast);

        left_fly_Enemy.StartSpawn(fast);
        right_fly_Enemy.StartSpawn(fast);

        left_Boss.StartSpawn(2147483647);

        ten = true;
    }
    #endregion

}
