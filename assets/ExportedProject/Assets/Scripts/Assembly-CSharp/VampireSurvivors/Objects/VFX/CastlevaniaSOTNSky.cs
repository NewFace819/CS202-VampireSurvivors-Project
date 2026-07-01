using UnityEngine;
using UnityEngine.Serialization;
using VampireSurvivors.Signals;
using Zenject;

namespace VampireSurvivors.Objects.VFX
{
	[DefaultExecutionOrder(960)]
	public class CastlevaniaSOTNSky : GameMonoBehaviour
	{
		private static readonly int MainTexMultiply;

		[Header("Platforming area")]
		[SerializeField]
		private bool IsWithinPlatformingArea;

		[SerializeField]
		private Vector2 BottomLeftPlatformingArea;

		[SerializeField]
		private Vector2 TopRightPlatformingArea;

		[SerializeField]
		private float PlatformingSkyboxHeight;

		[SerializeField]
		private float PlatformingGizmoWidth;

		[SerializeField]
		private float PlatformingGizmoHeight;

		[SerializeField]
		private float BlitRendererPlatformScale;

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
		private MeshRenderer FloorRenderer;

		[SerializeField]
		private ParticleSystem CloudFX;

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

		private void DisableBackground()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected void LateUpdate()
		{
		}

		private void UpdateShader(bool isInPlatformingArea)
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
