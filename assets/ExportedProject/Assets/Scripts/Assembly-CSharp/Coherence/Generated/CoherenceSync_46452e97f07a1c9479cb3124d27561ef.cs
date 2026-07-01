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
using VampireSurvivors.Objects.Characters.Enemies;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_46452e97f07a1c9479cb3124d27561ef : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _46452e97f07a1c9479cb3124d27561ef_97b46201bcf446d0bfb19f94985fe79d_CommandTarget;

		private Enemy_TP_GateBoss _46452e97f07a1c9479cb3124d27561ef_d8623b0a4e494c6199bab040195b56d8_CommandTarget;

		private Enemy_TP_GateBoss _46452e97f07a1c9479cb3124d27561ef_e28b9f906f7b4e448b57dec57db32f11_CommandTarget;

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

		private void BakeCommandBinding__46452e97f07a1c9479cb3124d27561ef_97b46201bcf446d0bfb19f94985fe79d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__46452e97f07a1c9479cb3124d27561ef_97b46201bcf446d0bfb19f94985fe79d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__46452e97f07a1c9479cb3124d27561ef_97b46201bcf446d0bfb19f94985fe79d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__46452e97f07a1c9479cb3124d27561ef_97b46201bcf446d0bfb19f94985fe79d(_46452e97f07a1c9479cb3124d27561ef_97b46201bcf446d0bfb19f94985fe79d command)
		{
		}

		private void BakeCommandBinding__46452e97f07a1c9479cb3124d27561ef_d8623b0a4e494c6199bab040195b56d8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__46452e97f07a1c9479cb3124d27561ef_d8623b0a4e494c6199bab040195b56d8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__46452e97f07a1c9479cb3124d27561ef_d8623b0a4e494c6199bab040195b56d8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__46452e97f07a1c9479cb3124d27561ef_d8623b0a4e494c6199bab040195b56d8(_46452e97f07a1c9479cb3124d27561ef_d8623b0a4e494c6199bab040195b56d8 command)
		{
		}

		private void BakeCommandBinding__46452e97f07a1c9479cb3124d27561ef_e28b9f906f7b4e448b57dec57db32f11(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__46452e97f07a1c9479cb3124d27561ef_e28b9f906f7b4e448b57dec57db32f11(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__46452e97f07a1c9479cb3124d27561ef_e28b9f906f7b4e448b57dec57db32f11(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__46452e97f07a1c9479cb3124d27561ef_e28b9f906f7b4e448b57dec57db32f11(_46452e97f07a1c9479cb3124d27561ef_e28b9f906f7b4e448b57dec57db32f11 command)
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
