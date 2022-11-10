using UnityEngine;

namespace ZY
{
    /// <summary>
    /// 
    /// </summary>

    public class CharacterController : MonoBehaviour
    {
        [Header("���ʳt��")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 3.5f;
        [SerializeField, Range(0, 10)]
        private float speedHorizontal = 4f;
        [Header("�Ϥ�")]
        [SerializeField] private Sprite Picturemiddle;
        [SerializeField, Header("�Ϥ���V����")]
        private SpriteRenderer spr;

        private void Update()
        {
            float v = Input.GetAxis("Vertical");
            float h = Input.GetAxis("Horizontal");
            
            transform.Translate(speedHorizontal * Time.deltaTime*h, speedVertical * Time.deltaTime*v,0);
        }


    }
}