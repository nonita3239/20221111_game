using UnityEngine;

namespace ZY
{ 
    /// <summary>
    /// 敵人發射系統
    /// </summary>
    public class EnemyFireSystem : FireSystembase
    {
        [SerializeField, Header("生成子彈間隔"), Range(0, 3)]
        private float interval = 1.5f;
    
    
        private void Awake()
        { 
        InvokeRepeating("SpawnBullet", 0, interval);
        }

    }
}
