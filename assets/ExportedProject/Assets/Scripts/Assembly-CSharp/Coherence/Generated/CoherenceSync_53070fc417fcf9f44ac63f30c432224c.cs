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
	public class CoherenceSync_53070fc417fcf9f44ac63f30c432224c : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _53070fc417fcf9f44ac63f30c432224c_1913b702ca794cea9552be8903eed092_CommandTarget;

		private NetworkPickup _53070fc417fcf9f44ac63f30c432224c_46d6fd1369e745cbbafe40b1ea881784_CommandTarget;

		private NetworkPickup _53070fc417fcf9f44ac63f30c432224c_d6111f47b9f94feaa83eb09c0a4fcb69_CommandTarget;

		private NetworkPickup _53070fc417fcf9f44ac63f30c432224c_786f38407e494f98b1c74032cee82b49_CommandTarget;

		private NetworkPickup _53070fc417fcf9f44ac63f30c432224c_93399b6dc0ad47a1b7521fba052fd9a5_CommandTarget;

		private NetworkPickup _53070fc417fcf9f44ac63f30c432224c_c6e438c71ee64a509562c30a10de39d9_CommandTarget;

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

		private void BakeCommandBinding__53070fc417fcf9f44ac63f30c432224c_1913b702ca794cea9552be8903eed092(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__53070fc417fcf9f44ac63f30c432224c_1913b702ca794cea9552be8903eed092(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__53070fc417fcf9f44ac63f30c432224c_1913b702ca794cea9552be8903eed092(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__53070fc417fcf9f44ac63f30c432224c_1913b702ca794cea9552be8903eed092(_53070fc417fcf9f44ac63f30c432224c_1913b702ca794cea9552be8903eed092 command)
		{
		}

		private void BakeCommandBinding__53070fc417fcf9f44ac63f30c432224c_46d6fd1369e745cbbafe40b1ea881784(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__53070fc417fcf9f44ac63f30c432224c_46d6fd1369e745cbbafe40b1ea881784(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__53070fc417fcf9f44ac63f30c432224c_46d6fd1369e745cbbafe40b1ea881784(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__53070fc417fcf9f44ac63f30c432224c_46d6fd1369e745cbbafe40b1ea881784(_53070fc417fcf9f44ac63f30c432224c_46d6fd1369e745cbbafe40b1ea881784 command)
		{
		}

		private void BakeCommandBinding__53070fc417fcf9f44ac63f30c432224c_d6111f47b9f94feaa83eb09c0a4fcb69(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__53070fc417fcf9f44ac63f30c432224c_d6111f47b9f94feaa83eb09c0a4fcb69(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__53070fc417fcf9f44ac63f30c432224c_d6111f47b9f94feaa83eb09c0a4fcb69(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__53070fc417fcf9f44ac63f30c432224c_d6111f47b9f94feaa83eb09c0a4fcb69(_53070fc417fcf9f44ac63f30c432224c_d6111f47b9f94feaa83eb09c0a4fcb69 command)
		{
		}

		private void BakeCommandBinding__53070fc417fcf9f44ac63f30c432224c_786f38407e494f98b1c74032cee82b49(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__53070fc417fcf9f44ac63f30c432224c_786f38407e494f98b1c74032cee82b49(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__53070fc417fcf9f44ac63f30c432224c_786f38407e494f98b1c74032cee82b49(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__53070fc417fcf9f44ac63f30c432224c_786f38407e494f98b1c74032cee82b49(_53070fc417fcf9f44ac63f30c432224c_786f38407e494f98b1c74032cee82b49 command)
		{
		}

		private void BakeCommandBinding__53070fc417fcf9f44ac63f30c432224c_93399b6dc0ad47a1b7521fba052fd9a5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__53070fc417fcf9f44ac63f30c432224c_93399b6dc0ad47a1b7521fba052fd9a5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__53070fc417fcf9f44ac63f30c432224c_93399b6dc0ad47a1b7521fba052fd9a5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__53070fc417fcf9f44ac63f30c432224c_93399b6dc0ad47a1b7521fba052fd9a5(_53070fc417fcf9f44ac63f30c432224c_93399b6dc0ad47a1b7521fba052fd9a5 command)
		{
		}

		private void BakeCommandBinding__53070fc417fcf9f44ac63f30c432224c_c6e438c71ee64a509562c30a10de39d9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__53070fc417fcf9f44ac63f30c432224c_c6e438c71ee64a509562c30a10de39d9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__53070fc417fcf9f44ac63f30c432224c_c6e438c71ee64a509562c30a10de39d9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__53070fc417fcf9f44ac63f30c432224c_c6e438c71ee64a509562c30a10de39d9(_53070fc417fcf9f44ac63f30c432224c_c6e438c71ee64a509562c30a10de39d9 command)
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
