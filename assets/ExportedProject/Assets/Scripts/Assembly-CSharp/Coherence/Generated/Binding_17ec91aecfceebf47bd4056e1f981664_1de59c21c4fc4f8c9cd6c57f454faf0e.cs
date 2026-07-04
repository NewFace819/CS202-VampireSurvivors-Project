using System;
using Coherence.Entities;
using Coherence.SimulationFrame;
using Coherence.Toolkit.Bindings.ValueBindings;
using UnityEngine;
using UnityEngine.Scripting;
using VampireSurvivors.Objects.Characters;

namespace Coherence.Generated
{
	[Preserve]
	public class Binding_17ec91aecfceebf47bd4056e1f981664_1de59c21c4fc4f8c9cd6c57f454faf0e : Vector2Binding
	{
		private TP_Character CastedUnityComponent;

		public override Type CoherenceComponentType => null;

		public override string CoherenceComponentName => null;

		public override uint FieldMask => 0u;

		public override Vector2 Value
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		protected override void OnBindingCloned()
		{
		}

		protected override (Vector2, AbsoluteSimulationFrame) ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
		{
			return default((Vector2, AbsoluteSimulationFrame));
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
