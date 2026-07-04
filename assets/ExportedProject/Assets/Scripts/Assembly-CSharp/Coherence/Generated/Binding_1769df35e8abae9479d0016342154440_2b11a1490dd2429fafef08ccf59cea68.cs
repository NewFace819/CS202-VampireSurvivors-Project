using System;
using Coherence.Entities;
using Coherence.SimulationFrame;
using Coherence.Toolkit.Bindings.TransformBindings;
using UnityEngine;
using UnityEngine.Scripting;

namespace Coherence.Generated
{
	[Preserve]
	public class Binding_1769df35e8abae9479d0016342154440_2b11a1490dd2429fafef08ccf59cea68 : PositionBinding
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
