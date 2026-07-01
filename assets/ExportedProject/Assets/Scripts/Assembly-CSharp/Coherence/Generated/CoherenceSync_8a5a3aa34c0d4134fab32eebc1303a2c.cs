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
	public class CoherenceSync_8a5a3aa34c0d4134fab32eebc1303a2c : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _8a5a3aa34c0d4134fab32eebc1303a2c_a23b377d39a341a2986c485f31e8d8cd_CommandTarget;

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

		private void BakeCommandBinding__8a5a3aa34c0d4134fab32eebc1303a2c_a23b377d39a341a2986c485f31e8d8cd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__8a5a3aa34c0d4134fab32eebc1303a2c_a23b377d39a341a2986c485f31e8d8cd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__8a5a3aa34c0d4134fab32eebc1303a2c_a23b377d39a341a2986c485f31e8d8cd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__8a5a3aa34c0d4134fab32eebc1303a2c_a23b377d39a341a2986c485f31e8d8cd(_8a5a3aa34c0d4134fab32eebc1303a2c_a23b377d39a341a2986c485f31e8d8cd command)
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
