using System;
using Coherence.Entities;
using Coherence.SimulationFrame;
using Coherence.Toolkit.Bindings.TransformBindings;
using UnityEngine;
using UnityEngine.Scripting;

namespace Coherence.Generated
{
	[Preserve]
	public class Binding_a66f3e563634fb24ea9738112145366f_31fdcec1390644e29fe3dc98974c160b : DeepRotationBinding
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
