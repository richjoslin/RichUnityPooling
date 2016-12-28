using UnityEngine;
using System.Collections;
using RichJoslin.Pooling;

public class PoolBall : MonoBehaviour, IPooledInstanceGet, IPooledInstanceReturn
{
	public static PoolBall Generate()
	{
		PoolBall poolBall = PoolManager.I.GetPooler("Ball Key").Get<PoolBall>();
		poolBall.StartCoroutine("LifetimeLoop");
		return poolBall;
	}

	public IEnumerator LifetimeLoop()
	{
		yield return new WaitForSeconds(2f);
		PoolManager.I.Return(this);
	}

	// IPooledInstanceGet
	public void OnGet(UnityEngine.Object arg = null)
	{
		// do stuff as soon as it's gotten from a pooler
	}

	// IPooledInstanceReturn
	public void OnReturn()
	{
		// do stuff as soon as it's returned to a pooler
	}
}
