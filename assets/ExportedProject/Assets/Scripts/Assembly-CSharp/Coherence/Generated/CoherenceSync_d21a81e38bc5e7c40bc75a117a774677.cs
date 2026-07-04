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
	public class CoherenceSync_d21a81e38bc5e7c40bc75a117a774677 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _d21a81e38bc5e7c40bc75a117a774677_a1ce04709a1743f6a7d25aab47b2a25f_CommandTarget;

		private Enemy_TP_GateBoss _d21a81e38bc5e7c40bc75a117a774677_c82dab4c86ee40c58e2baa8d8e0e72c4_CommandTarget;

		private Enemy_TP_GateBoss _d21a81e38bc5e7c40bc75a117a774677_5ecc66b45b9a45988e28b6579b4656c8_CommandTarget;

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

		private void BakeCommandBinding__d21a81e38bc5e7c40bc75a117a774677_a1ce04709a1743f6a7d25aab47b2a25f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d21a81e38bc5e7c40bc75a117a774677_a1ce04709a1743f6a7d25aab47b2a25f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d21a81e38bc5e7c40bc75a117a774677_a1ce04709a1743f6a7d25aab47b2a25f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d21a81e38bc5e7c40bc75a117a774677_a1ce04709a1743f6a7d25aab47b2a25f(_d21a81e38bc5e7c40bc75a117a774677_a1ce04709a1743f6a7d25aab47b2a25f command)
		{
		}

		private void BakeCommandBinding__d21a81e38bc5e7c40bc75a117a774677_c82dab4c86ee40c58e2baa8d8e0e72c4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d21a81e38bc5e7c40bc75a117a774677_c82dab4c86ee40c58e2baa8d8e0e72c4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d21a81e38bc5e7c40bc75a117a774677_c82dab4c86ee40c58e2baa8d8e0e72c4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d21a81e38bc5e7c40bc75a117a774677_c82dab4c86ee40c58e2baa8d8e0e72c4(_d21a81e38bc5e7c40bc75a117a774677_c82dab4c86ee40c58e2baa8d8e0e72c4 command)
		{
		}

		private void BakeCommandBinding__d21a81e38bc5e7c40bc75a117a774677_5ecc66b45b9a45988e28b6579b4656c8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d21a81e38bc5e7c40bc75a117a774677_5ecc66b45b9a45988e28b6579b4656c8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d21a81e38bc5e7c40bc75a117a774677_5ecc66b45b9a45988e28b6579b4656c8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d21a81e38bc5e7c40bc75a117a774677_5ecc66b45b9a45988e28b6579b4656c8(_d21a81e38bc5e7c40bc75a117a774677_5ecc66b45b9a45988e28b6579b4656c8 command)
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
