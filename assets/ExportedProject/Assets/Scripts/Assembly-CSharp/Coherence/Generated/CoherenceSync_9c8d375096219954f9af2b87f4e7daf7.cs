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
	public class CoherenceSync_9c8d375096219954f9af2b87f4e7daf7 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _9c8d375096219954f9af2b87f4e7daf7_7722589b7e7f4a778c36cff3fe229d68_CommandTarget;

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

		private void BakeCommandBinding__9c8d375096219954f9af2b87f4e7daf7_7722589b7e7f4a778c36cff3fe229d68(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__9c8d375096219954f9af2b87f4e7daf7_7722589b7e7f4a778c36cff3fe229d68(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__9c8d375096219954f9af2b87f4e7daf7_7722589b7e7f4a778c36cff3fe229d68(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__9c8d375096219954f9af2b87f4e7daf7_7722589b7e7f4a778c36cff3fe229d68(_9c8d375096219954f9af2b87f4e7daf7_7722589b7e7f4a778c36cff3fe229d68 command)
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
