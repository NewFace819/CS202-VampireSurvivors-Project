using System;
using System.Collections.Generic;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using UnityEngine.Scripting;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Props;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_4183ddc80bfde7146a7c3ee151141e84 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private Destructible _4183ddc80bfde7146a7c3ee151141e84_e77cf4e8780d461287e90e905d09966b_CommandTarget;

		private Prop_AnimatedExplosive_Tohil _4183ddc80bfde7146a7c3ee151141e84_f0e3bfbe8a6448f3bba75a812f69050b_CommandTarget;

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

		private void BakeCommandBinding__4183ddc80bfde7146a7c3ee151141e84_e77cf4e8780d461287e90e905d09966b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4183ddc80bfde7146a7c3ee151141e84_e77cf4e8780d461287e90e905d09966b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4183ddc80bfde7146a7c3ee151141e84_e77cf4e8780d461287e90e905d09966b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4183ddc80bfde7146a7c3ee151141e84_e77cf4e8780d461287e90e905d09966b(_4183ddc80bfde7146a7c3ee151141e84_e77cf4e8780d461287e90e905d09966b command)
		{
		}

		private void BakeCommandBinding__4183ddc80bfde7146a7c3ee151141e84_f0e3bfbe8a6448f3bba75a812f69050b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__4183ddc80bfde7146a7c3ee151141e84_f0e3bfbe8a6448f3bba75a812f69050b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__4183ddc80bfde7146a7c3ee151141e84_f0e3bfbe8a6448f3bba75a812f69050b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__4183ddc80bfde7146a7c3ee151141e84_f0e3bfbe8a6448f3bba75a812f69050b(_4183ddc80bfde7146a7c3ee151141e84_f0e3bfbe8a6448f3bba75a812f69050b command)
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
