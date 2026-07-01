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
	public class CoherenceSync_ce0df8e5912f90943882b6184d83ea28 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private EnemyController _ce0df8e5912f90943882b6184d83ea28_26f2d93953c64cab868d8e1cf582ebb5_CommandTarget;

		private Enemy_TP_GateBoss _ce0df8e5912f90943882b6184d83ea28_04453ce5be3240dda34052b14e09824a_CommandTarget;

		private Enemy_TP_GateBoss _ce0df8e5912f90943882b6184d83ea28_8b555fc2559c431fad463fe5472df562_CommandTarget;

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

		private void BakeCommandBinding__ce0df8e5912f90943882b6184d83ea28_26f2d93953c64cab868d8e1cf582ebb5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ce0df8e5912f90943882b6184d83ea28_26f2d93953c64cab868d8e1cf582ebb5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ce0df8e5912f90943882b6184d83ea28_26f2d93953c64cab868d8e1cf582ebb5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ce0df8e5912f90943882b6184d83ea28_26f2d93953c64cab868d8e1cf582ebb5(_ce0df8e5912f90943882b6184d83ea28_26f2d93953c64cab868d8e1cf582ebb5 command)
		{
		}

		private void BakeCommandBinding__ce0df8e5912f90943882b6184d83ea28_04453ce5be3240dda34052b14e09824a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ce0df8e5912f90943882b6184d83ea28_04453ce5be3240dda34052b14e09824a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ce0df8e5912f90943882b6184d83ea28_04453ce5be3240dda34052b14e09824a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ce0df8e5912f90943882b6184d83ea28_04453ce5be3240dda34052b14e09824a(_ce0df8e5912f90943882b6184d83ea28_04453ce5be3240dda34052b14e09824a command)
		{
		}

		private void BakeCommandBinding__ce0df8e5912f90943882b6184d83ea28_8b555fc2559c431fad463fe5472df562(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ce0df8e5912f90943882b6184d83ea28_8b555fc2559c431fad463fe5472df562(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ce0df8e5912f90943882b6184d83ea28_8b555fc2559c431fad463fe5472df562(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ce0df8e5912f90943882b6184d83ea28_8b555fc2559c431fad463fe5472df562(_ce0df8e5912f90943882b6184d83ea28_8b555fc2559c431fad463fe5472df562 command)
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
