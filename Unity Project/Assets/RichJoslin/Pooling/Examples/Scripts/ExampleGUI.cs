using UnityEngine;

public class ExampleGUI : MonoBehaviour
{
	void OnGUI()
	{
		GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
		{
			GUILayout.BeginHorizontal();
			{
				GUILayout.FlexibleSpace();
				GUILayout.BeginVertical();
				{
					GUILayout.Space(100f);
					if (GUILayout.Button("Generate Ball"))
					{
						PoolBall poolBall = PoolBall.Generate();
					}
					GUILayout.FlexibleSpace();
				}
				GUILayout.EndVertical();
				GUILayout.FlexibleSpace();
			}
			GUILayout.EndHorizontal();
		}
		GUILayout.EndArea();
	}
}
