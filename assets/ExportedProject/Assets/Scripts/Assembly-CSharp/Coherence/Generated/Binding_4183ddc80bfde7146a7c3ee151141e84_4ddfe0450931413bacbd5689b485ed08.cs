using System;
using Coherence.Entities;
using Coherence.SimulationFrame;
using Coherence.Toolkit.Bindings.TransformBindings;
using UnityEngine;
using UnityEngine.Scripting;

namespace Coherence.Generated
{
	[Preserve]
	public class Binding_4183ddc80bfde7146a7c3ee151141e84_4ddfe0450931413bacbd5689b485ed08 : PositionBinding
	{
		private Transform CastedUnityComponent;

		public override Type CoherenceComponentType => null;

		public override string CoherenceComponentName => null;

		public override uint FieldMask => 0u;

		public override Vector3 Value
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		protected override void OnBindingCloned()
		{
		}

		protected override (Vector3, AbsoluteSimulationFrame) ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
		{
			return default((Vector3, AbsoluteSimulationFrame));
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
