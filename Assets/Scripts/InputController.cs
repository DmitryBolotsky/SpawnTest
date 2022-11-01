using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InputController : MonoBehaviour
{
   [SerializeField]
   private CubeBehaviour m_cubeBehaviour;
   [SerializeField]
   private Spawner m_spawner;

   public void ChangeDistance(string input)
   {
      float res;
      float.TryParse(input, out res);
      m_cubeBehaviour.m_distance = res;
   }
   public void ChangeSpeed(string input)
   {
      float res;
      float.TryParse(input, out res);
      m_cubeBehaviour.m_speed = res;
   }
   public void ChangeInterval(string input)
   {
      float res;
      float.TryParse(input, out res);
      m_spawner.m_interval = res;
   }
}
