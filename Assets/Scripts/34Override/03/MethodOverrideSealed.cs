using UnityEngine;

namespace MethodOverride
{ 
   public class MethodOverrideSealed : MonoBehaviour
   {
      // Start is called once before the first execution of Update after the MonoBehaviour is created
      void Start()
      {
           //�θ� Ŭ���� �ν��Ͻ� ����
           ParentDev parent = new ParentDev();
           parent.Work();

           //�ڽ� Ŭ���� �ν��Ͻ� ����
           ChildDev child = new ChildDev();
           child.Work();

           //���� Ŭ���� �ν��Ͻ� ����
           GrandChildDev grandChild = new GrandChildDev();
           grandChild.Work();
           grandChild.Play();
      }

 
   }
}
