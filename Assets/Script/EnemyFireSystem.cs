using UnityEngine;

namespace ZY
{ 
    /// <summary>
    /// �ĤH�o�g�t��
    /// </summary>
    public class EnemyFireSystem : FireSystembase
    {
        [SerializeField, Header("�ͦ��l�u���j"), Range(0, 3)]
        private float interval = 1.5f;
    
    
        private void Awake()
        { 
        InvokeRepeating("SpawnBullet", 0, interval);
        }

    }
}
