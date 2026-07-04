using System;
using Coherence.Entities;
using Coherence.SimulationFrame;
using Coherence.Toolkit.Bindings.TransformBindings;
using UnityEngine;
using UnityEngine.Scripting;

namespace Coherence.Generated
{
	[Preserve]
	public class Binding_728cd6037975de34a9c410d6903798fd_efc01f85dc1c4912984e9a941650d7cc : DeepRotationBinding
	{
		private Transform CastedUnityComponent;

		public override Type CoherenceComponentType => null;

		public override string CoherenceComponentName => null;

		public override uint FieldMask => 0u;

		public override Quaternion Value
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		protected override void OnBindingCloned()
		{
		}

		protected override (Quaternion, AbsoluteSimulationFrame) ReadComponentData(ICoherenceComponentData coherenceComponent, Vector3 floatingOriginDelta)
		{
			return default((Quaternion, AbsoluteSimulationFrame));
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
