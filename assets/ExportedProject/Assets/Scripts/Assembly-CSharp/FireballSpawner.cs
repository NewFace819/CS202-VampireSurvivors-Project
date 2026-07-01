using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FireballSpawner : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSpawnFireball_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitTime;

		public FireballSpawner _003C_003E4__this;

		public bool lastFireball;

		private GameObject _003Cfireball_003E5__2;

		private float _003Ctimer_003E5__3;

		private ParticleSystem _003Cexplosion_003E5__4;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CSpawnFireball_003Ed__16(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CSpawnUppercut_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitTime;

		public FireballSpawner _003C_003E4__this;

		private ParticleSystem _003CuppercutFX_003E5__2;

		private GameObject _003CfireballUppercutFX_003E5__3;

		private float _003Ctimer_003E5__4;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CSpawnUppercut_003Ed__17(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public GameObject fireballPrefab;

	public ParticleSystem explosionEffect;

	public ParticleSystem UpperCutPrefab;

	public GameObject UpperCutFireballPrefab;

	public float WaitTime;

	public Vector3 movementAxis;

	public float startSpeed;

	public float endSpeed;

	public float speedChangeDuration;

	public float moveDuration;

	public bool spawnInCircleArea;

	public Vector3 circleAxis;

	public float circleRadius;

	private Vector3 endPosition;

	private void Start()
	{
	}

	private void FireballSequence()
	{
	}

	[IteratorStateMachine(typeof(_003CSpawnFireball_003Ed__16))]
	private IEnumerator SpawnFireball(float waitTime, bool lastFireball = false)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CSpawnUppercut_003Ed__17))]
	private IEnumerator SpawnUppercut(float waitTime)
	{
		return null;
	}

	private void OnDrawGizmos()
	{
	}
}
