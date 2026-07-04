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
	public class CoherenceSync_7938f2765629f1d48a3f666ccfd0b0a2 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _7938f2765629f1d48a3f666ccfd0b0a2_16e98fda4b084a68a49c9432fe4279bf_CommandTarget;

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

		private void BakeCommandBinding__7938f2765629f1d48a3f666ccfd0b0a2_16e98fda4b084a68a49c9432fe4279bf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7938f2765629f1d48a3f666ccfd0b0a2_16e98fda4b084a68a49c9432fe4279bf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7938f2765629f1d48a3f666ccfd0b0a2_16e98fda4b084a68a49c9432fe4279bf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7938f2765629f1d48a3f666ccfd0b0a2_16e98fda4b084a68a49c9432fe4279bf(_7938f2765629f1d48a3f666ccfd0b0a2_16e98fda4b084a68a49c9432fe4279bf command)
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
