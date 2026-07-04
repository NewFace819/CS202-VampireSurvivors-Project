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
	public class CoherenceSync_7da04e07cab36834bb9c2cbe01890c4e : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _7da04e07cab36834bb9c2cbe01890c4e_039a89be2864459c80c8f04fdff2ae97_CommandTarget;

		private NetworkPickup _7da04e07cab36834bb9c2cbe01890c4e_82907dd249584584ae4256b2e438c513_CommandTarget;

		private NetworkPickup _7da04e07cab36834bb9c2cbe01890c4e_51563e0613834561ad64facf2899ecbd_CommandTarget;

		private NetworkPickup _7da04e07cab36834bb9c2cbe01890c4e_9d9650497eb544759e439f8f04d25121_CommandTarget;

		private NetworkPickup _7da04e07cab36834bb9c2cbe01890c4e_9b2e4f4e4884415ba1ee054d5d3c560b_CommandTarget;

		private NetworkPickup _7da04e07cab36834bb9c2cbe01890c4e_574f9efc295741ee96b4ee8850c26077_CommandTarget;

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

		private void BakeCommandBinding__7da04e07cab36834bb9c2cbe01890c4e_039a89be2864459c80c8f04fdff2ae97(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7da04e07cab36834bb9c2cbe01890c4e_039a89be2864459c80c8f04fdff2ae97(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7da04e07cab36834bb9c2cbe01890c4e_039a89be2864459c80c8f04fdff2ae97(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7da04e07cab36834bb9c2cbe01890c4e_039a89be2864459c80c8f04fdff2ae97(_7da04e07cab36834bb9c2cbe01890c4e_039a89be2864459c80c8f04fdff2ae97 command)
		{
		}

		private void BakeCommandBinding__7da04e07cab36834bb9c2cbe01890c4e_82907dd249584584ae4256b2e438c513(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7da04e07cab36834bb9c2cbe01890c4e_82907dd249584584ae4256b2e438c513(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7da04e07cab36834bb9c2cbe01890c4e_82907dd249584584ae4256b2e438c513(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7da04e07cab36834bb9c2cbe01890c4e_82907dd249584584ae4256b2e438c513(_7da04e07cab36834bb9c2cbe01890c4e_82907dd249584584ae4256b2e438c513 command)
		{
		}

		private void BakeCommandBinding__7da04e07cab36834bb9c2cbe01890c4e_51563e0613834561ad64facf2899ecbd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7da04e07cab36834bb9c2cbe01890c4e_51563e0613834561ad64facf2899ecbd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7da04e07cab36834bb9c2cbe01890c4e_51563e0613834561ad64facf2899ecbd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7da04e07cab36834bb9c2cbe01890c4e_51563e0613834561ad64facf2899ecbd(_7da04e07cab36834bb9c2cbe01890c4e_51563e0613834561ad64facf2899ecbd command)
		{
		}

		private void BakeCommandBinding__7da04e07cab36834bb9c2cbe01890c4e_9d9650497eb544759e439f8f04d25121(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7da04e07cab36834bb9c2cbe01890c4e_9d9650497eb544759e439f8f04d25121(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7da04e07cab36834bb9c2cbe01890c4e_9d9650497eb544759e439f8f04d25121(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7da04e07cab36834bb9c2cbe01890c4e_9d9650497eb544759e439f8f04d25121(_7da04e07cab36834bb9c2cbe01890c4e_9d9650497eb544759e439f8f04d25121 command)
		{
		}

		private void BakeCommandBinding__7da04e07cab36834bb9c2cbe01890c4e_9b2e4f4e4884415ba1ee054d5d3c560b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7da04e07cab36834bb9c2cbe01890c4e_9b2e4f4e4884415ba1ee054d5d3c560b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7da04e07cab36834bb9c2cbe01890c4e_9b2e4f4e4884415ba1ee054d5d3c560b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7da04e07cab36834bb9c2cbe01890c4e_9b2e4f4e4884415ba1ee054d5d3c560b(_7da04e07cab36834bb9c2cbe01890c4e_9b2e4f4e4884415ba1ee054d5d3c560b command)
		{
		}

		private void BakeCommandBinding__7da04e07cab36834bb9c2cbe01890c4e_574f9efc295741ee96b4ee8850c26077(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__7da04e07cab36834bb9c2cbe01890c4e_574f9efc295741ee96b4ee8850c26077(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__7da04e07cab36834bb9c2cbe01890c4e_574f9efc295741ee96b4ee8850c26077(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__7da04e07cab36834bb9c2cbe01890c4e_574f9efc295741ee96b4ee8850c26077(_7da04e07cab36834bb9c2cbe01890c4e_574f9efc295741ee96b4ee8850c26077 command)
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
