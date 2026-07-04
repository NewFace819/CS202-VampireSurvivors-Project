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
	public class CoherenceSync_a66f3e563634fb24ea9738112145366f : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _a66f3e563634fb24ea9738112145366f_3052feeb788f4e61b6d97555f9d0a518_CommandTarget;

		private CharacterController _a66f3e563634fb24ea9738112145366f_02dc2f9f9dde4921bccf4385c0063eab_CommandTarget;

		private CharacterController _a66f3e563634fb24ea9738112145366f_0776bf3814c149bea12b1f1e64c6334c_CommandTarget;

		private CharacterController _a66f3e563634fb24ea9738112145366f_56af61ff548547b983ae6ceeaf5888da_CommandTarget;

		private CharacterController _a66f3e563634fb24ea9738112145366f_7e26102e74d3445786b6600461688abb_CommandTarget;

		private CharacterController _a66f3e563634fb24ea9738112145366f_061f1b5c1e4b42edac9c10ec324bb9e6_CommandTarget;

		private CharacterController _a66f3e563634fb24ea9738112145366f_64bac0acac7444f5bd8839f97dd299c8_CommandTarget;

		private CharacterController _a66f3e563634fb24ea9738112145366f_a88fd211cdf947748f6b2620da059281_CommandTarget;

		private CharacterController _a66f3e563634fb24ea9738112145366f_e090816deb974eb7a75d733835c6d053_CommandTarget;

		private CharacterController _a66f3e563634fb24ea9738112145366f_4724419d9c5c4ababce5befda38009dc_CommandTarget;

		private CharacterController _a66f3e563634fb24ea9738112145366f_24e3db126e6345d8b8eae92bda562db2_CommandTarget;

		private CharacterController _a66f3e563634fb24ea9738112145366f_c804649e260a42589785a99755a02552_CommandTarget;

		private TP_Annette_Character _a66f3e563634fb24ea9738112145366f_3f2f5f0a0ae04378a19679f63d0cde8a_CommandTarget;

		private CharacterController _a66f3e563634fb24ea9738112145366f_ac810917cd5d47c99686ce1e10cf4edc_CommandTarget;

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

		private void BakeCommandBinding__a66f3e563634fb24ea9738112145366f_3052feeb788f4e61b6d97555f9d0a518(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a66f3e563634fb24ea9738112145366f_3052feeb788f4e61b6d97555f9d0a518(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a66f3e563634fb24ea9738112145366f_3052feeb788f4e61b6d97555f9d0a518(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a66f3e563634fb24ea9738112145366f_3052feeb788f4e61b6d97555f9d0a518(_a66f3e563634fb24ea9738112145366f_3052feeb788f4e61b6d97555f9d0a518 command)
		{
		}

		private void BakeCommandBinding__a66f3e563634fb24ea9738112145366f_02dc2f9f9dde4921bccf4385c0063eab(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a66f3e563634fb24ea9738112145366f_02dc2f9f9dde4921bccf4385c0063eab(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a66f3e563634fb24ea9738112145366f_02dc2f9f9dde4921bccf4385c0063eab(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a66f3e563634fb24ea9738112145366f_02dc2f9f9dde4921bccf4385c0063eab(_a66f3e563634fb24ea9738112145366f_02dc2f9f9dde4921bccf4385c0063eab command)
		{
		}

		private void BakeCommandBinding__a66f3e563634fb24ea9738112145366f_0776bf3814c149bea12b1f1e64c6334c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a66f3e563634fb24ea9738112145366f_0776bf3814c149bea12b1f1e64c6334c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a66f3e563634fb24ea9738112145366f_0776bf3814c149bea12b1f1e64c6334c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a66f3e563634fb24ea9738112145366f_0776bf3814c149bea12b1f1e64c6334c(_a66f3e563634fb24ea9738112145366f_0776bf3814c149bea12b1f1e64c6334c command)
		{
		}

		private void BakeCommandBinding__a66f3e563634fb24ea9738112145366f_56af61ff548547b983ae6ceeaf5888da(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a66f3e563634fb24ea9738112145366f_56af61ff548547b983ae6ceeaf5888da(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a66f3e563634fb24ea9738112145366f_56af61ff548547b983ae6ceeaf5888da(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a66f3e563634fb24ea9738112145366f_56af61ff548547b983ae6ceeaf5888da(_a66f3e563634fb24ea9738112145366f_56af61ff548547b983ae6ceeaf5888da command)
		{
		}

		private void BakeCommandBinding__a66f3e563634fb24ea9738112145366f_7e26102e74d3445786b6600461688abb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a66f3e563634fb24ea9738112145366f_7e26102e74d3445786b6600461688abb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a66f3e563634fb24ea9738112145366f_7e26102e74d3445786b6600461688abb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a66f3e563634fb24ea9738112145366f_7e26102e74d3445786b6600461688abb(_a66f3e563634fb24ea9738112145366f_7e26102e74d3445786b6600461688abb command)
		{
		}

		private void BakeCommandBinding__a66f3e563634fb24ea9738112145366f_061f1b5c1e4b42edac9c10ec324bb9e6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a66f3e563634fb24ea9738112145366f_061f1b5c1e4b42edac9c10ec324bb9e6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a66f3e563634fb24ea9738112145366f_061f1b5c1e4b42edac9c10ec324bb9e6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a66f3e563634fb24ea9738112145366f_061f1b5c1e4b42edac9c10ec324bb9e6(_a66f3e563634fb24ea9738112145366f_061f1b5c1e4b42edac9c10ec324bb9e6 command)
		{
		}

		private void BakeCommandBinding__a66f3e563634fb24ea9738112145366f_64bac0acac7444f5bd8839f97dd299c8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a66f3e563634fb24ea9738112145366f_64bac0acac7444f5bd8839f97dd299c8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a66f3e563634fb24ea9738112145366f_64bac0acac7444f5bd8839f97dd299c8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a66f3e563634fb24ea9738112145366f_64bac0acac7444f5bd8839f97dd299c8(_a66f3e563634fb24ea9738112145366f_64bac0acac7444f5bd8839f97dd299c8 command)
		{
		}

		private void BakeCommandBinding__a66f3e563634fb24ea9738112145366f_a88fd211cdf947748f6b2620da059281(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a66f3e563634fb24ea9738112145366f_a88fd211cdf947748f6b2620da059281(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a66f3e563634fb24ea9738112145366f_a88fd211cdf947748f6b2620da059281(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a66f3e563634fb24ea9738112145366f_a88fd211cdf947748f6b2620da059281(_a66f3e563634fb24ea9738112145366f_a88fd211cdf947748f6b2620da059281 command)
		{
		}

		private void BakeCommandBinding__a66f3e563634fb24ea9738112145366f_e090816deb974eb7a75d733835c6d053(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a66f3e563634fb24ea9738112145366f_e090816deb974eb7a75d733835c6d053(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a66f3e563634fb24ea9738112145366f_e090816deb974eb7a75d733835c6d053(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a66f3e563634fb24ea9738112145366f_e090816deb974eb7a75d733835c6d053(_a66f3e563634fb24ea9738112145366f_e090816deb974eb7a75d733835c6d053 command)
		{
		}

		private void BakeCommandBinding__a66f3e563634fb24ea9738112145366f_4724419d9c5c4ababce5befda38009dc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a66f3e563634fb24ea9738112145366f_4724419d9c5c4ababce5befda38009dc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a66f3e563634fb24ea9738112145366f_4724419d9c5c4ababce5befda38009dc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a66f3e563634fb24ea9738112145366f_4724419d9c5c4ababce5befda38009dc(_a66f3e563634fb24ea9738112145366f_4724419d9c5c4ababce5befda38009dc command)
		{
		}

		private void BakeCommandBinding__a66f3e563634fb24ea9738112145366f_24e3db126e6345d8b8eae92bda562db2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a66f3e563634fb24ea9738112145366f_24e3db126e6345d8b8eae92bda562db2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a66f3e563634fb24ea9738112145366f_24e3db126e6345d8b8eae92bda562db2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a66f3e563634fb24ea9738112145366f_24e3db126e6345d8b8eae92bda562db2(_a66f3e563634fb24ea9738112145366f_24e3db126e6345d8b8eae92bda562db2 command)
		{
		}

		private void BakeCommandBinding__a66f3e563634fb24ea9738112145366f_c804649e260a42589785a99755a02552(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a66f3e563634fb24ea9738112145366f_c804649e260a42589785a99755a02552(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a66f3e563634fb24ea9738112145366f_c804649e260a42589785a99755a02552(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a66f3e563634fb24ea9738112145366f_c804649e260a42589785a99755a02552(_a66f3e563634fb24ea9738112145366f_c804649e260a42589785a99755a02552 command)
		{
		}

		private void BakeCommandBinding__a66f3e563634fb24ea9738112145366f_3f2f5f0a0ae04378a19679f63d0cde8a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a66f3e563634fb24ea9738112145366f_3f2f5f0a0ae04378a19679f63d0cde8a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a66f3e563634fb24ea9738112145366f_3f2f5f0a0ae04378a19679f63d0cde8a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a66f3e563634fb24ea9738112145366f_3f2f5f0a0ae04378a19679f63d0cde8a(_a66f3e563634fb24ea9738112145366f_3f2f5f0a0ae04378a19679f63d0cde8a command)
		{
		}

		private void BakeCommandBinding__a66f3e563634fb24ea9738112145366f_ac810917cd5d47c99686ce1e10cf4edc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__a66f3e563634fb24ea9738112145366f_ac810917cd5d47c99686ce1e10cf4edc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__a66f3e563634fb24ea9738112145366f_ac810917cd5d47c99686ce1e10cf4edc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__a66f3e563634fb24ea9738112145366f_ac810917cd5d47c99686ce1e10cf4edc(_a66f3e563634fb24ea9738112145366f_ac810917cd5d47c99686ce1e10cf4edc command)
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
