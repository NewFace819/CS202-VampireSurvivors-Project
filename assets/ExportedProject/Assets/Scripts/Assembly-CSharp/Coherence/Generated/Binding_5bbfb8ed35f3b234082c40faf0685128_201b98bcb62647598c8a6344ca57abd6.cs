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
	public class Binding_5bbfb8ed35f3b234082c40faf0685128_201b98bcb62647598c8a6344ca57abd6 : StringBinding
	{
		private Pickup_FB_RapidFire CastedUnityComponent;

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
