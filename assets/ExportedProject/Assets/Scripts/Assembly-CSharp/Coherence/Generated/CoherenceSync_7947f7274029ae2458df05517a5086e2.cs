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
	public class CoherenceSync_7947f7274029ae2458df05517a5086e2 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _7947f7274029ae2458df05517a5086e2_33699feb59e44c96a9eba5a3cb7db4ad_CommandTarget;

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

		private void BakeCommandBinding__7947f7274029ae2458df05517a5086e2_33699feb59e44c96a9eba5a3cb7db4ad(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7947f7274029ae2458df05517a5086e2_33699feb59e44c96a9eba5a3cb7db4ad(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7947f7274029ae2458df05517a5086e2_33699feb59e44c96a9eba5a3cb7db4ad(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7947f7274029ae2458df05517a5086e2_33699feb59e44c96a9eba5a3cb7db4ad(_7947f7274029ae2458df05517a5086e2_33699feb59e44c96a9eba5a3cb7db4ad command)
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
