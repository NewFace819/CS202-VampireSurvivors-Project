using System;
using System.Collections.Generic;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using UnityEngine.Scripting;
using VampireSurvivors;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_03c1f4b7bee855a40bc8b8c91cc978b6 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _03c1f4b7bee855a40bc8b8c91cc978b6_ed8e4918b7b34f408de546d97f08a437_CommandTarget;

		private NetworkPickup _03c1f4b7bee855a40bc8b8c91cc978b6_152886b542bc4e83966b7dd44c229c2c_CommandTarget;

		private NetworkPickup _03c1f4b7bee855a40bc8b8c91cc978b6_60b1f07dd10a4695b55d81228c57b040_CommandTarget;

		private NetworkPickup _03c1f4b7bee855a40bc8b8c91cc978b6_178ead1cbffc40a3aeb60af82a1801a3_CommandTarget;

		private NetworkPickup _03c1f4b7bee855a40bc8b8c91cc978b6_0ad11e9a9ed241609222e51512dc1053_CommandTarget;

		private NetworkPickup _03c1f4b7bee855a40bc8b8c91cc978b6_fc17bbdc81b344279bc5e77016899da2_CommandTarget;

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

		private void BakeCommandBinding__03c1f4b7bee855a40bc8b8c91cc978b6_ed8e4918b7b34f408de546d97f08a437(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__03c1f4b7bee855a40bc8b8c91cc978b6_ed8e4918b7b34f408de546d97f08a437(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__03c1f4b7bee855a40bc8b8c91cc978b6_ed8e4918b7b34f408de546d97f08a437(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__03c1f4b7bee855a40bc8b8c91cc978b6_ed8e4918b7b34f408de546d97f08a437(_03c1f4b7bee855a40bc8b8c91cc978b6_ed8e4918b7b34f408de546d97f08a437 command)
		{
		}

		private void BakeCommandBinding__03c1f4b7bee855a40bc8b8c91cc978b6_152886b542bc4e83966b7dd44c229c2c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__03c1f4b7bee855a40bc8b8c91cc978b6_152886b542bc4e83966b7dd44c229c2c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__03c1f4b7bee855a40bc8b8c91cc978b6_152886b542bc4e83966b7dd44c229c2c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__03c1f4b7bee855a40bc8b8c91cc978b6_152886b542bc4e83966b7dd44c229c2c(_03c1f4b7bee855a40bc8b8c91cc978b6_152886b542bc4e83966b7dd44c229c2c command)
		{
		}

		private void BakeCommandBinding__03c1f4b7bee855a40bc8b8c91cc978b6_60b1f07dd10a4695b55d81228c57b040(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__03c1f4b7bee855a40bc8b8c91cc978b6_60b1f07dd10a4695b55d81228c57b040(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__03c1f4b7bee855a40bc8b8c91cc978b6_60b1f07dd10a4695b55d81228c57b040(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__03c1f4b7bee855a40bc8b8c91cc978b6_60b1f07dd10a4695b55d81228c57b040(_03c1f4b7bee855a40bc8b8c91cc978b6_60b1f07dd10a4695b55d81228c57b040 command)
		{
		}

		private void BakeCommandBinding__03c1f4b7bee855a40bc8b8c91cc978b6_178ead1cbffc40a3aeb60af82a1801a3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__03c1f4b7bee855a40bc8b8c91cc978b6_178ead1cbffc40a3aeb60af82a1801a3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__03c1f4b7bee855a40bc8b8c91cc978b6_178ead1cbffc40a3aeb60af82a1801a3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__03c1f4b7bee855a40bc8b8c91cc978b6_178ead1cbffc40a3aeb60af82a1801a3(_03c1f4b7bee855a40bc8b8c91cc978b6_178ead1cbffc40a3aeb60af82a1801a3 command)
		{
		}

		private void BakeCommandBinding__03c1f4b7bee855a40bc8b8c91cc978b6_0ad11e9a9ed241609222e51512dc1053(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__03c1f4b7bee855a40bc8b8c91cc978b6_0ad11e9a9ed241609222e51512dc1053(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__03c1f4b7bee855a40bc8b8c91cc978b6_0ad11e9a9ed241609222e51512dc1053(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__03c1f4b7bee855a40bc8b8c91cc978b6_0ad11e9a9ed241609222e51512dc1053(_03c1f4b7bee855a40bc8b8c91cc978b6_0ad11e9a9ed241609222e51512dc1053 command)
		{
		}

		private void BakeCommandBinding__03c1f4b7bee855a40bc8b8c91cc978b6_fc17bbdc81b344279bc5e77016899da2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__03c1f4b7bee855a40bc8b8c91cc978b6_fc17bbdc81b344279bc5e77016899da2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__03c1f4b7bee855a40bc8b8c91cc978b6_fc17bbdc81b344279bc5e77016899da2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__03c1f4b7bee855a40bc8b8c91cc978b6_fc17bbdc81b344279bc5e77016899da2(_03c1f4b7bee855a40bc8b8c91cc978b6_fc17bbdc81b344279bc5e77016899da2 command)
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
