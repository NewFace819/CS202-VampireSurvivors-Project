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
	public class CoherenceSync_a652ede624feed4499930176817c4a4e : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _a652ede624feed4499930176817c4a4e_81878e6a9b0347cea050fb728a874005_CommandTarget;

		private CharacterController _a652ede624feed4499930176817c4a4e_b37b5e81d7ec45aeab0670fa455a8ad8_CommandTarget;

		private CharacterController _a652ede624feed4499930176817c4a4e_732195dbdffb42dd94b33cae3fb3efde_CommandTarget;

		private CharacterController _a652ede624feed4499930176817c4a4e_4a05dc197c2b42049f0bfadb0fc8f737_CommandTarget;

		private CharacterController _a652ede624feed4499930176817c4a4e_dbc1fbcef91a4cffa65a6900f9d77de1_CommandTarget;

		private CharacterController _a652ede624feed4499930176817c4a4e_63004901a85546afaa9e486a06d80570_CommandTarget;

		private CharacterController _a652ede624feed4499930176817c4a4e_b1ab6c3c9af44cd4b2a2ed082ae8fd83_CommandTarget;

		private CharacterController _a652ede624feed4499930176817c4a4e_ebcfaf1772ad4614b1d23ffc54003939_CommandTarget;

		private CharacterController _a652ede624feed4499930176817c4a4e_e348a8055b884ecd8d41e2afff405d4a_CommandTarget;

		private CharacterController _a652ede624feed4499930176817c4a4e_68c4490417c049708630e9e4cacc6663_CommandTarget;

		private CharacterController _a652ede624feed4499930176817c4a4e_858b9e992e4842a6b673bc00e537c6e0_CommandTarget;

		private CharacterController _a652ede624feed4499930176817c4a4e_6f7b4de1bf0f41329a8e515b8b68ae79_CommandTarget;

		private CharacterController _a652ede624feed4499930176817c4a4e_b8d4b8bbfbe6468db2ce5d08ca364ecc_CommandTarget;

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

		private void BakeCommandBinding__a652ede624feed4499930176817c4a4e_81878e6a9b0347cea050fb728a874005(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a652ede624feed4499930176817c4a4e_81878e6a9b0347cea050fb728a874005(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a652ede624feed4499930176817c4a4e_81878e6a9b0347cea050fb728a874005(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a652ede624feed4499930176817c4a4e_81878e6a9b0347cea050fb728a874005(_a652ede624feed4499930176817c4a4e_81878e6a9b0347cea050fb728a874005 command)
		{
		}

		private void BakeCommandBinding__a652ede624feed4499930176817c4a4e_b37b5e81d7ec45aeab0670fa455a8ad8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a652ede624feed4499930176817c4a4e_b37b5e81d7ec45aeab0670fa455a8ad8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a652ede624feed4499930176817c4a4e_b37b5e81d7ec45aeab0670fa455a8ad8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a652ede624feed4499930176817c4a4e_b37b5e81d7ec45aeab0670fa455a8ad8(_a652ede624feed4499930176817c4a4e_b37b5e81d7ec45aeab0670fa455a8ad8 command)
		{
		}

		private void BakeCommandBinding__a652ede624feed4499930176817c4a4e_732195dbdffb42dd94b33cae3fb3efde(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a652ede624feed4499930176817c4a4e_732195dbdffb42dd94b33cae3fb3efde(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a652ede624feed4499930176817c4a4e_732195dbdffb42dd94b33cae3fb3efde(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a652ede624feed4499930176817c4a4e_732195dbdffb42dd94b33cae3fb3efde(_a652ede624feed4499930176817c4a4e_732195dbdffb42dd94b33cae3fb3efde command)
		{
		}

		private void BakeCommandBinding__a652ede624feed4499930176817c4a4e_4a05dc197c2b42049f0bfadb0fc8f737(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a652ede624feed4499930176817c4a4e_4a05dc197c2b42049f0bfadb0fc8f737(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a652ede624feed4499930176817c4a4e_4a05dc197c2b42049f0bfadb0fc8f737(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a652ede624feed4499930176817c4a4e_4a05dc197c2b42049f0bfadb0fc8f737(_a652ede624feed4499930176817c4a4e_4a05dc197c2b42049f0bfadb0fc8f737 command)
		{
		}

		private void BakeCommandBinding__a652ede624feed4499930176817c4a4e_dbc1fbcef91a4cffa65a6900f9d77de1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a652ede624feed4499930176817c4a4e_dbc1fbcef91a4cffa65a6900f9d77de1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a652ede624feed4499930176817c4a4e_dbc1fbcef91a4cffa65a6900f9d77de1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a652ede624feed4499930176817c4a4e_dbc1fbcef91a4cffa65a6900f9d77de1(_a652ede624feed4499930176817c4a4e_dbc1fbcef91a4cffa65a6900f9d77de1 command)
		{
		}

		private void BakeCommandBinding__a652ede624feed4499930176817c4a4e_63004901a85546afaa9e486a06d80570(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a652ede624feed4499930176817c4a4e_63004901a85546afaa9e486a06d80570(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a652ede624feed4499930176817c4a4e_63004901a85546afaa9e486a06d80570(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a652ede624feed4499930176817c4a4e_63004901a85546afaa9e486a06d80570(_a652ede624feed4499930176817c4a4e_63004901a85546afaa9e486a06d80570 command)
		{
		}

		private void BakeCommandBinding__a652ede624feed4499930176817c4a4e_b1ab6c3c9af44cd4b2a2ed082ae8fd83(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a652ede624feed4499930176817c4a4e_b1ab6c3c9af44cd4b2a2ed082ae8fd83(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a652ede624feed4499930176817c4a4e_b1ab6c3c9af44cd4b2a2ed082ae8fd83(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a652ede624feed4499930176817c4a4e_b1ab6c3c9af44cd4b2a2ed082ae8fd83(_a652ede624feed4499930176817c4a4e_b1ab6c3c9af44cd4b2a2ed082ae8fd83 command)
		{
		}

		private void BakeCommandBinding__a652ede624feed4499930176817c4a4e_ebcfaf1772ad4614b1d23ffc54003939(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a652ede624feed4499930176817c4a4e_ebcfaf1772ad4614b1d23ffc54003939(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a652ede624feed4499930176817c4a4e_ebcfaf1772ad4614b1d23ffc54003939(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a652ede624feed4499930176817c4a4e_ebcfaf1772ad4614b1d23ffc54003939(_a652ede624feed4499930176817c4a4e_ebcfaf1772ad4614b1d23ffc54003939 command)
		{
		}

		private void BakeCommandBinding__a652ede624feed4499930176817c4a4e_e348a8055b884ecd8d41e2afff405d4a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a652ede624feed4499930176817c4a4e_e348a8055b884ecd8d41e2afff405d4a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a652ede624feed4499930176817c4a4e_e348a8055b884ecd8d41e2afff405d4a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a652ede624feed4499930176817c4a4e_e348a8055b884ecd8d41e2afff405d4a(_a652ede624feed4499930176817c4a4e_e348a8055b884ecd8d41e2afff405d4a command)
		{
		}

		private void BakeCommandBinding__a652ede624feed4499930176817c4a4e_68c4490417c049708630e9e4cacc6663(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a652ede624feed4499930176817c4a4e_68c4490417c049708630e9e4cacc6663(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a652ede624feed4499930176817c4a4e_68c4490417c049708630e9e4cacc6663(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a652ede624feed4499930176817c4a4e_68c4490417c049708630e9e4cacc6663(_a652ede624feed4499930176817c4a4e_68c4490417c049708630e9e4cacc6663 command)
		{
		}

		private void BakeCommandBinding__a652ede624feed4499930176817c4a4e_858b9e992e4842a6b673bc00e537c6e0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a652ede624feed4499930176817c4a4e_858b9e992e4842a6b673bc00e537c6e0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a652ede624feed4499930176817c4a4e_858b9e992e4842a6b673bc00e537c6e0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a652ede624feed4499930176817c4a4e_858b9e992e4842a6b673bc00e537c6e0(_a652ede624feed4499930176817c4a4e_858b9e992e4842a6b673bc00e537c6e0 command)
		{
		}

		private void BakeCommandBinding__a652ede624feed4499930176817c4a4e_6f7b4de1bf0f41329a8e515b8b68ae79(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a652ede624feed4499930176817c4a4e_6f7b4de1bf0f41329a8e515b8b68ae79(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a652ede624feed4499930176817c4a4e_6f7b4de1bf0f41329a8e515b8b68ae79(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a652ede624feed4499930176817c4a4e_6f7b4de1bf0f41329a8e515b8b68ae79(_a652ede624feed4499930176817c4a4e_6f7b4de1bf0f41329a8e515b8b68ae79 command)
		{
		}

		private void BakeCommandBinding__a652ede624feed4499930176817c4a4e_b8d4b8bbfbe6468db2ce5d08ca364ecc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a652ede624feed4499930176817c4a4e_b8d4b8bbfbe6468db2ce5d08ca364ecc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a652ede624feed4499930176817c4a4e_b8d4b8bbfbe6468db2ce5d08ca364ecc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a652ede624feed4499930176817c4a4e_b8d4b8bbfbe6468db2ce5d08ca364ecc(_a652ede624feed4499930176817c4a4e_b8d4b8bbfbe6468db2ce5d08ca364ecc command)
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
