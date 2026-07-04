using System;
using Coherence.Entities;
using Coherence.SimulationFrame;
using Coherence.Toolkit.Bindings.ValueBindings;
using UnityEngine;
using UnityEngine.Scripting;
using VampireSurvivors.Objects.Items;

namespace Coherence.Generated
{
	[Preserve]
	public class Binding_1b1887fdb3ea8f14ba3cbc6f5b788a7a_3c09eca329244d108ae2884aaeb23b92 : StringBinding
	{
		private PickupCoffinEmpty CastedUnityComponent;

		public override Type CoherenceComponentType => null;

		public override string CoherenceComponentName => null;

		public override uint FieldMask => 0u;

		public override string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void OnBindingCloned()
		{
		}

		protected override (string, AbsoluteSimulationFrame) ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
		{
			return default((string, AbsoluteSimulationFrame));
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
