using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using VampireSurvivors.Signals;
using Zenject;

namespace VampireSurvivors.Objects.VFX
{
	[DefaultExecutionOrder(960)]
	public class EmeraldsSkybox : GameMonoBehaviour
	{
		[FormerlySerializedAs("_renderTexture")]
		[Header("Sky RT components")]
		[SerializeField]
		private RenderTexture RenderTexture;

		[SerializeField]
		private MeshRenderer BlitRenderer;

		[SerializeField]
		private Camera _cam;

		[Header("Pausable components")]
		[SerializeField]
		private List<Material> CloudMaterials;

		[FormerlySerializedAs("CloudFX")]
		[SerializeField]
		private ParticleSystem FloatingDoorsFX;

		private bool _initialised;

		private Transform BlitRendererCachedTransform;

		private Material FloorMaterial;

		private Camera MainCam;

		private bool _shouldBeVisible;

		private SignalBus _signalBus;

		private void Start()
		{
		}

		[Inject]
		private void Construct(SignalBus signalBus)
		{
		}

		private void Initialise()
		{
		}

		private void OnGameQuit()
		{
		}

		private void SetBackgroundVisible(GameplaySignals.SetBackgroundVisible signal)
		{
		}

		protected override void OnUpdate()
		{
		}

		protected void LateUpdate()
		{
		}

		private void UpdateShader()
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
