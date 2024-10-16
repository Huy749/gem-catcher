using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemFallScript : MonoBehaviour
{
    // khai bao bien chua prefab cua vien ngoc, day la doi tuong se tao trong tro choi
    public GameObject gemPrefab;
    // khai bao bien san sinh gem tu lan cuoi cung
    private float timer;
    //khoang thoi gian tin bang giay tu moi lan san sinh
    public float spawnInterval = 3f;// tan suat spawn 3 giay / 1 gem


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //cong don thoi gian tu lan cuoi cung
        timer += Time.deltaTime;
        //kie tra neu time du lon bang hoan lon hon khoang thoi gian sinh ngoc
        if (timer >= spawnInterval)
        {
            SpawnGem(); // goi ham sinh ngoc
            timer = 0;  // dat laij bien thoi gian

        }
    }
    void SpawnGem()
    {
        // tao bien ngau nhien
        float randomX = Random.Range(-8f, 8f);

        // tao ra vien ngoc o vi tri co dinh tren man hinh
        Vector3 spawnposition = new Vector3(randomX, 6f, 0);//Vector3 (toa do x, toa do y, toa do z)

        //su dung Instantiate de tao ra ban sao cura prelab vien ngoc tai vi tri va huing duy dinh
        Instantiate(gemPrefab, spawnposition, Quaternion.identity); // Instantiate(Object nao, vi tri)

    }
}
