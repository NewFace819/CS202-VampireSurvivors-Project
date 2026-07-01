using System;
using System.Collections.Generic;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using UnityEngine.Scripting;
using VampireSurvivors.Objects.Characters;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_d560f31ab1f8a314abb47afabd725958 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _d560f31ab1f8a314abb47afabd725958_ccac8c62127847248bc25fd59b903893_CommandTarget;

		private IClient client;

		private CoherenceBridge bridge;

		private readonly Dictionary<string, Binding> bakedValueBindings;

		private Dictionary<string, Action<CommandBinding, CommandsHandler>> bakedCommandBindings;

		public override Binding BakeValueBinding(Binding valueBinding)
		{
			return null;
		}

		public override void BakeCommandBinding(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void BakeCommandBinding__d560f31ab1f8a314abb47afabd725958_ccac8c62127847248bc25fd59b903893(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d560f31ab1f8a314abb47afabd725958_ccac8c62127847248bc25fd59b903893(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d560f31ab1f8a314abb47afabd725958_ccac8c62127847248bc25fd59b903893(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d560f31ab1f8a314abb47afabd725958_ccac8c62127847248bc25fd59b903893(_d560f31ab1f8a314abb47afabd725958_ccac8c62127847248bc25fd59b903893 command)
		{
		}

		public override void ReceiveCommand(IEntityCommand command)
		{
		}

		public override void CreateEntity(bool usesLodsAtRuntime, string archetypeName, AbsoluteSimulationFrame simFrame, List<ICoherenceComponentData> components)
		{
		}

		public override void Dispose()
		{
		}

		public override void Initialize(Entity entityId, CoherenceBridge bridge, IClient client, CoherenceInput input, Logger logger)
		{
		}
	}
}
