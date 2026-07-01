using Unity.IL2CPP.CompilerServices;
using UnityEngine;

public class TestNativeSet : MonoBehaviour
{
	[SerializeField]
	protected int numObjects;

	protected Transform[] objects;

	protected int mode;

	private void Start()
	{
	}

	private void Update()
	{
	}

	[Il2CppSetOption(/*Could not decode attribute arguments.*/)]
	[Il2CppSetOption(/*Could not decode attribute arguments.*/)]
	private void UpdatePositionsLocalIl2Cpp()
	{
	}

	private void UpdatePositionsGlobal()
	{
	}

	private void UpdatePositionsLocal()
	{
	}
}
