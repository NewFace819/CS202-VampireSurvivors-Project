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
	public class CoherenceSync_99bbdbd1ce167d240a740fa0a7532924 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _99bbdbd1ce167d240a740fa0a7532924_2080d0ac9b784d16a83bd51bc0e4c866_CommandTarget;

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

		private void BakeCommandBinding__99bbdbd1ce167d240a740fa0a7532924_2080d0ac9b784d16a83bd51bc0e4c866(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__99bbdbd1ce167d240a740fa0a7532924_2080d0ac9b784d16a83bd51bc0e4c866(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__99bbdbd1ce167d240a740fa0a7532924_2080d0ac9b784d16a83bd51bc0e4c866(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__99bbdbd1ce167d240a740fa0a7532924_2080d0ac9b784d16a83bd51bc0e4c866(_99bbdbd1ce167d240a740fa0a7532924_2080d0ac9b784d16a83bd51bc0e4c866 command)
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
