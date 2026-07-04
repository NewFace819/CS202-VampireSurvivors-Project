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
	public class CoherenceSync_33ffda2513e96a141b7aeea34a14f870 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _33ffda2513e96a141b7aeea34a14f870_0383c0e5cc67449b8bdcbc59f32dca07_CommandTarget;

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

		private void BakeCommandBinding__33ffda2513e96a141b7aeea34a14f870_0383c0e5cc67449b8bdcbc59f32dca07(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__33ffda2513e96a141b7aeea34a14f870_0383c0e5cc67449b8bdcbc59f32dca07(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__33ffda2513e96a141b7aeea34a14f870_0383c0e5cc67449b8bdcbc59f32dca07(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__33ffda2513e96a141b7aeea34a14f870_0383c0e5cc67449b8bdcbc59f32dca07(_33ffda2513e96a141b7aeea34a14f870_0383c0e5cc67449b8bdcbc59f32dca07 command)
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
