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
	public class CoherenceSync_2a87a58318e06c444903296a69cecb18 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _2a87a58318e06c444903296a69cecb18_0284968d0a27431fa286e3cbdb09153b_CommandTarget;

		private NetworkPickup _2a87a58318e06c444903296a69cecb18_9e0f5f19b3914987aa69588dce762fbc_CommandTarget;

		private NetworkPickup _2a87a58318e06c444903296a69cecb18_b23daa137b2f48fb9b84f00c656bb4d0_CommandTarget;

		private NetworkPickup _2a87a58318e06c444903296a69cecb18_fedc6bd5e1344c6098580e619637d37b_CommandTarget;

		private NetworkPickup _2a87a58318e06c444903296a69cecb18_a8ccfe32008f43128a9ba8670226c76a_CommandTarget;

		private NetworkPickup _2a87a58318e06c444903296a69cecb18_59ce8057dce148508ee090f5cfd90b30_CommandTarget;

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

		private void BakeCommandBinding__2a87a58318e06c444903296a69cecb18_0284968d0a27431fa286e3cbdb09153b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2a87a58318e06c444903296a69cecb18_0284968d0a27431fa286e3cbdb09153b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2a87a58318e06c444903296a69cecb18_0284968d0a27431fa286e3cbdb09153b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2a87a58318e06c444903296a69cecb18_0284968d0a27431fa286e3cbdb09153b(_2a87a58318e06c444903296a69cecb18_0284968d0a27431fa286e3cbdb09153b command)
		{
		}

		private void BakeCommandBinding__2a87a58318e06c444903296a69cecb18_9e0f5f19b3914987aa69588dce762fbc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2a87a58318e06c444903296a69cecb18_9e0f5f19b3914987aa69588dce762fbc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2a87a58318e06c444903296a69cecb18_9e0f5f19b3914987aa69588dce762fbc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2a87a58318e06c444903296a69cecb18_9e0f5f19b3914987aa69588dce762fbc(_2a87a58318e06c444903296a69cecb18_9e0f5f19b3914987aa69588dce762fbc command)
		{
		}

		private void BakeCommandBinding__2a87a58318e06c444903296a69cecb18_b23daa137b2f48fb9b84f00c656bb4d0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2a87a58318e06c444903296a69cecb18_b23daa137b2f48fb9b84f00c656bb4d0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2a87a58318e06c444903296a69cecb18_b23daa137b2f48fb9b84f00c656bb4d0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2a87a58318e06c444903296a69cecb18_b23daa137b2f48fb9b84f00c656bb4d0(_2a87a58318e06c444903296a69cecb18_b23daa137b2f48fb9b84f00c656bb4d0 command)
		{
		}

		private void BakeCommandBinding__2a87a58318e06c444903296a69cecb18_fedc6bd5e1344c6098580e619637d37b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2a87a58318e06c444903296a69cecb18_fedc6bd5e1344c6098580e619637d37b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2a87a58318e06c444903296a69cecb18_fedc6bd5e1344c6098580e619637d37b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2a87a58318e06c444903296a69cecb18_fedc6bd5e1344c6098580e619637d37b(_2a87a58318e06c444903296a69cecb18_fedc6bd5e1344c6098580e619637d37b command)
		{
		}

		private void BakeCommandBinding__2a87a58318e06c444903296a69cecb18_a8ccfe32008f43128a9ba8670226c76a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2a87a58318e06c444903296a69cecb18_a8ccfe32008f43128a9ba8670226c76a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2a87a58318e06c444903296a69cecb18_a8ccfe32008f43128a9ba8670226c76a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2a87a58318e06c444903296a69cecb18_a8ccfe32008f43128a9ba8670226c76a(_2a87a58318e06c444903296a69cecb18_a8ccfe32008f43128a9ba8670226c76a command)
		{
		}

		private void BakeCommandBinding__2a87a58318e06c444903296a69cecb18_59ce8057dce148508ee090f5cfd90b30(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__2a87a58318e06c444903296a69cecb18_59ce8057dce148508ee090f5cfd90b30(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__2a87a58318e06c444903296a69cecb18_59ce8057dce148508ee090f5cfd90b30(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__2a87a58318e06c444903296a69cecb18_59ce8057dce148508ee090f5cfd90b30(_2a87a58318e06c444903296a69cecb18_59ce8057dce148508ee090f5cfd90b30 command)
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
