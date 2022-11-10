using UnityEngine;

namespace ZY
{
    /// <summary>
    /// 玩家發射系統
    /// </summary>
    public class PlayerFireSystem : FireSystembase
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }
        }

    }
}
