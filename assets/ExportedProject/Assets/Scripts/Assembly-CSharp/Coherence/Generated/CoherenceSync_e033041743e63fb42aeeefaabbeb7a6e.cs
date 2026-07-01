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
	public class CoherenceSync_e033041743e63fb42aeeefaabbeb7a6e : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _e033041743e63fb42aeeefaabbeb7a6e_697b8101db154b648087ecc358ce45eb_CommandTarget;

		private NetworkPickup _e033041743e63fb42aeeefaabbeb7a6e_ea204a31846c42d7877239a4d0f50621_CommandTarget;

		private NetworkPickup _e033041743e63fb42aeeefaabbeb7a6e_05d8b1f0bc554f839b33e8b9caa638db_CommandTarget;

		private NetworkPickup _e033041743e63fb42aeeefaabbeb7a6e_a33d867224d44e58947846a1a7567603_CommandTarget;

		private NetworkPickup _e033041743e63fb42aeeefaabbeb7a6e_82835877d38b4e099c9c0e952bc82a1f_CommandTarget;

		private NetworkPickup _e033041743e63fb42aeeefaabbeb7a6e_36a23826e9b3446c84fc65cfc3cd072b_CommandTarget;

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

		private void BakeCommandBinding__e033041743e63fb42aeeefaabbeb7a6e_697b8101db154b648087ecc358ce45eb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e033041743e63fb42aeeefaabbeb7a6e_697b8101db154b648087ecc358ce45eb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e033041743e63fb42aeeefaabbeb7a6e_697b8101db154b648087ecc358ce45eb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e033041743e63fb42aeeefaabbeb7a6e_697b8101db154b648087ecc358ce45eb(_e033041743e63fb42aeeefaabbeb7a6e_697b8101db154b648087ecc358ce45eb command)
		{
		}

		private void BakeCommandBinding__e033041743e63fb42aeeefaabbeb7a6e_ea204a31846c42d7877239a4d0f50621(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e033041743e63fb42aeeefaabbeb7a6e_ea204a31846c42d7877239a4d0f50621(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e033041743e63fb42aeeefaabbeb7a6e_ea204a31846c42d7877239a4d0f50621(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e033041743e63fb42aeeefaabbeb7a6e_ea204a31846c42d7877239a4d0f50621(_e033041743e63fb42aeeefaabbeb7a6e_ea204a31846c42d7877239a4d0f50621 command)
		{
		}

		private void BakeCommandBinding__e033041743e63fb42aeeefaabbeb7a6e_05d8b1f0bc554f839b33e8b9caa638db(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e033041743e63fb42aeeefaabbeb7a6e_05d8b1f0bc554f839b33e8b9caa638db(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e033041743e63fb42aeeefaabbeb7a6e_05d8b1f0bc554f839b33e8b9caa638db(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e033041743e63fb42aeeefaabbeb7a6e_05d8b1f0bc554f839b33e8b9caa638db(_e033041743e63fb42aeeefaabbeb7a6e_05d8b1f0bc554f839b33e8b9caa638db command)
		{
		}

		private void BakeCommandBinding__e033041743e63fb42aeeefaabbeb7a6e_a33d867224d44e58947846a1a7567603(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e033041743e63fb42aeeefaabbeb7a6e_a33d867224d44e58947846a1a7567603(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e033041743e63fb42aeeefaabbeb7a6e_a33d867224d44e58947846a1a7567603(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e033041743e63fb42aeeefaabbeb7a6e_a33d867224d44e58947846a1a7567603(_e033041743e63fb42aeeefaabbeb7a6e_a33d867224d44e58947846a1a7567603 command)
		{
		}

		private void BakeCommandBinding__e033041743e63fb42aeeefaabbeb7a6e_82835877d38b4e099c9c0e952bc82a1f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e033041743e63fb42aeeefaabbeb7a6e_82835877d38b4e099c9c0e952bc82a1f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e033041743e63fb42aeeefaabbeb7a6e_82835877d38b4e099c9c0e952bc82a1f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e033041743e63fb42aeeefaabbeb7a6e_82835877d38b4e099c9c0e952bc82a1f(_e033041743e63fb42aeeefaabbeb7a6e_82835877d38b4e099c9c0e952bc82a1f command)
		{
		}

		private void BakeCommandBinding__e033041743e63fb42aeeefaabbeb7a6e_36a23826e9b3446c84fc65cfc3cd072b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e033041743e63fb42aeeefaabbeb7a6e_36a23826e9b3446c84fc65cfc3cd072b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e033041743e63fb42aeeefaabbeb7a6e_36a23826e9b3446c84fc65cfc3cd072b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e033041743e63fb42aeeefaabbeb7a6e_36a23826e9b3446c84fc65cfc3cd072b(_e033041743e63fb42aeeefaabbeb7a6e_36a23826e9b3446c84fc65cfc3cd072b command)
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
