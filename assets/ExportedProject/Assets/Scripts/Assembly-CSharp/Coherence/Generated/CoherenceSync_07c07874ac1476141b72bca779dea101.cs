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
	public class CoherenceSync_07c07874ac1476141b72bca779dea101 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _07c07874ac1476141b72bca779dea101_460b7bb6e04c4807b4ae0263c2f8a21c_CommandTarget;

		private CharacterController _07c07874ac1476141b72bca779dea101_b921c7061ad146c4941a35c86ad7606b_CommandTarget;

		private CharacterController _07c07874ac1476141b72bca779dea101_c2814c7ec83c44c6835600e20c5eeb0b_CommandTarget;

		private CharacterController _07c07874ac1476141b72bca779dea101_fa39e1c20612443f879ea1b17aeaa3e6_CommandTarget;

		private CharacterController _07c07874ac1476141b72bca779dea101_113004dc9cc6418b8cecc64dab23c5cb_CommandTarget;

		private CharacterController _07c07874ac1476141b72bca779dea101_648372eab0d7453fb4d045af460cd5a9_CommandTarget;

		private CharacterController _07c07874ac1476141b72bca779dea101_623bd0db421e421b802e9fde294e1283_CommandTarget;

		private CharacterController _07c07874ac1476141b72bca779dea101_03a23cdb319b431f9bdf78d778927a81_CommandTarget;

		private CharacterController _07c07874ac1476141b72bca779dea101_d82f98edde724ac2bf9029acbdf9d7a7_CommandTarget;

		private CharacterController _07c07874ac1476141b72bca779dea101_ec9fe5289c144cdbaa40dbc1fb78a19a_CommandTarget;

		private CharacterController _07c07874ac1476141b72bca779dea101_b9cfa0511c334a12a3e26fc291882ac3_CommandTarget;

		private CharacterController _07c07874ac1476141b72bca779dea101_deea6673e4784f1e896841f1c10013ab_CommandTarget;

		private CharacterController _07c07874ac1476141b72bca779dea101_d7b0a65c5b2b459da5ad8ffc36aefd03_CommandTarget;

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

		private void BakeCommandBinding__07c07874ac1476141b72bca779dea101_460b7bb6e04c4807b4ae0263c2f8a21c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07c07874ac1476141b72bca779dea101_460b7bb6e04c4807b4ae0263c2f8a21c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07c07874ac1476141b72bca779dea101_460b7bb6e04c4807b4ae0263c2f8a21c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07c07874ac1476141b72bca779dea101_460b7bb6e04c4807b4ae0263c2f8a21c(_07c07874ac1476141b72bca779dea101_460b7bb6e04c4807b4ae0263c2f8a21c command)
		{
		}

		private void BakeCommandBinding__07c07874ac1476141b72bca779dea101_b921c7061ad146c4941a35c86ad7606b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07c07874ac1476141b72bca779dea101_b921c7061ad146c4941a35c86ad7606b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07c07874ac1476141b72bca779dea101_b921c7061ad146c4941a35c86ad7606b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07c07874ac1476141b72bca779dea101_b921c7061ad146c4941a35c86ad7606b(_07c07874ac1476141b72bca779dea101_b921c7061ad146c4941a35c86ad7606b command)
		{
		}

		private void BakeCommandBinding__07c07874ac1476141b72bca779dea101_c2814c7ec83c44c6835600e20c5eeb0b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07c07874ac1476141b72bca779dea101_c2814c7ec83c44c6835600e20c5eeb0b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07c07874ac1476141b72bca779dea101_c2814c7ec83c44c6835600e20c5eeb0b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07c07874ac1476141b72bca779dea101_c2814c7ec83c44c6835600e20c5eeb0b(_07c07874ac1476141b72bca779dea101_c2814c7ec83c44c6835600e20c5eeb0b command)
		{
		}

		private void BakeCommandBinding__07c07874ac1476141b72bca779dea101_fa39e1c20612443f879ea1b17aeaa3e6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07c07874ac1476141b72bca779dea101_fa39e1c20612443f879ea1b17aeaa3e6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07c07874ac1476141b72bca779dea101_fa39e1c20612443f879ea1b17aeaa3e6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07c07874ac1476141b72bca779dea101_fa39e1c20612443f879ea1b17aeaa3e6(_07c07874ac1476141b72bca779dea101_fa39e1c20612443f879ea1b17aeaa3e6 command)
		{
		}

		private void BakeCommandBinding__07c07874ac1476141b72bca779dea101_113004dc9cc6418b8cecc64dab23c5cb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07c07874ac1476141b72bca779dea101_113004dc9cc6418b8cecc64dab23c5cb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07c07874ac1476141b72bca779dea101_113004dc9cc6418b8cecc64dab23c5cb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07c07874ac1476141b72bca779dea101_113004dc9cc6418b8cecc64dab23c5cb(_07c07874ac1476141b72bca779dea101_113004dc9cc6418b8cecc64dab23c5cb command)
		{
		}

		private void BakeCommandBinding__07c07874ac1476141b72bca779dea101_648372eab0d7453fb4d045af460cd5a9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07c07874ac1476141b72bca779dea101_648372eab0d7453fb4d045af460cd5a9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07c07874ac1476141b72bca779dea101_648372eab0d7453fb4d045af460cd5a9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07c07874ac1476141b72bca779dea101_648372eab0d7453fb4d045af460cd5a9(_07c07874ac1476141b72bca779dea101_648372eab0d7453fb4d045af460cd5a9 command)
		{
		}

		private void BakeCommandBinding__07c07874ac1476141b72bca779dea101_623bd0db421e421b802e9fde294e1283(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07c07874ac1476141b72bca779dea101_623bd0db421e421b802e9fde294e1283(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07c07874ac1476141b72bca779dea101_623bd0db421e421b802e9fde294e1283(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07c07874ac1476141b72bca779dea101_623bd0db421e421b802e9fde294e1283(_07c07874ac1476141b72bca779dea101_623bd0db421e421b802e9fde294e1283 command)
		{
		}

		private void BakeCommandBinding__07c07874ac1476141b72bca779dea101_03a23cdb319b431f9bdf78d778927a81(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07c07874ac1476141b72bca779dea101_03a23cdb319b431f9bdf78d778927a81(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07c07874ac1476141b72bca779dea101_03a23cdb319b431f9bdf78d778927a81(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07c07874ac1476141b72bca779dea101_03a23cdb319b431f9bdf78d778927a81(_07c07874ac1476141b72bca779dea101_03a23cdb319b431f9bdf78d778927a81 command)
		{
		}

		private void BakeCommandBinding__07c07874ac1476141b72bca779dea101_d82f98edde724ac2bf9029acbdf9d7a7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07c07874ac1476141b72bca779dea101_d82f98edde724ac2bf9029acbdf9d7a7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07c07874ac1476141b72bca779dea101_d82f98edde724ac2bf9029acbdf9d7a7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07c07874ac1476141b72bca779dea101_d82f98edde724ac2bf9029acbdf9d7a7(_07c07874ac1476141b72bca779dea101_d82f98edde724ac2bf9029acbdf9d7a7 command)
		{
		}

		private void BakeCommandBinding__07c07874ac1476141b72bca779dea101_ec9fe5289c144cdbaa40dbc1fb78a19a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07c07874ac1476141b72bca779dea101_ec9fe5289c144cdbaa40dbc1fb78a19a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07c07874ac1476141b72bca779dea101_ec9fe5289c144cdbaa40dbc1fb78a19a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07c07874ac1476141b72bca779dea101_ec9fe5289c144cdbaa40dbc1fb78a19a(_07c07874ac1476141b72bca779dea101_ec9fe5289c144cdbaa40dbc1fb78a19a command)
		{
		}

		private void BakeCommandBinding__07c07874ac1476141b72bca779dea101_b9cfa0511c334a12a3e26fc291882ac3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07c07874ac1476141b72bca779dea101_b9cfa0511c334a12a3e26fc291882ac3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07c07874ac1476141b72bca779dea101_b9cfa0511c334a12a3e26fc291882ac3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07c07874ac1476141b72bca779dea101_b9cfa0511c334a12a3e26fc291882ac3(_07c07874ac1476141b72bca779dea101_b9cfa0511c334a12a3e26fc291882ac3 command)
		{
		}

		private void BakeCommandBinding__07c07874ac1476141b72bca779dea101_deea6673e4784f1e896841f1c10013ab(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07c07874ac1476141b72bca779dea101_deea6673e4784f1e896841f1c10013ab(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07c07874ac1476141b72bca779dea101_deea6673e4784f1e896841f1c10013ab(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07c07874ac1476141b72bca779dea101_deea6673e4784f1e896841f1c10013ab(_07c07874ac1476141b72bca779dea101_deea6673e4784f1e896841f1c10013ab command)
		{
		}

		private void BakeCommandBinding__07c07874ac1476141b72bca779dea101_d7b0a65c5b2b459da5ad8ffc36aefd03(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__07c07874ac1476141b72bca779dea101_d7b0a65c5b2b459da5ad8ffc36aefd03(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__07c07874ac1476141b72bca779dea101_d7b0a65c5b2b459da5ad8ffc36aefd03(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__07c07874ac1476141b72bca779dea101_d7b0a65c5b2b459da5ad8ffc36aefd03(_07c07874ac1476141b72bca779dea101_d7b0a65c5b2b459da5ad8ffc36aefd03 command)
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
