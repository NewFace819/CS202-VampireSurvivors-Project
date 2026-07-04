using System;
using Coherence.Entities;
using Coherence.SimulationFrame;
using Coherence.Toolkit.Bindings.ValueBindings;
using UnityEngine;
using UnityEngine.Scripting;
using VampireSurvivors.Objects.Characters.Enemies;

namespace Coherence.Generated
{
	[Preserve]
	public class Binding_981ac410cf05185489bc8e4f58953b63_e37c3092113b4b389bc7fe82be93edea : ReferenceBinding
	{
		private EnemyStaticPot CastedUnityComponent;

		public override Type CoherenceComponentType => null;

		public override string CoherenceComponentName => null;

		public override uint FieldMask => 0u;

		public override Entity Value
		{
			get
			{
				return default(Entity);
			}
			set
			{
			}
		}

		protected override void OnBindingCloned()
		{
		}

		protected override (Entity, AbsoluteSimulationFrame) ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
		{
			return default((Entity, AbsoluteSimulationFrame));
		}

		public override ICoherenceComponentData WriteComponentData(ICoherenceComponentData coherenceComponent, AbsoluteSimulationFrame simFrame)
		{
			return null;
		}

		public override ICoherenceComponentData CreateComponentData()
		{
			return null;
		}
	}
}
