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
	public class CoherenceSync_6cc9b126243967c42a13e9ca0e361dfd : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _6cc9b126243967c42a13e9ca0e361dfd_c6154915350342a6befc8966fece3054_CommandTarget;

		private CharacterController _6cc9b126243967c42a13e9ca0e361dfd_24483d6a494e43a1818fa9982e9cd307_CommandTarget;

		private CharacterController _6cc9b126243967c42a13e9ca0e361dfd_5a65dd76a28649c1bb19146751403ead_CommandTarget;

		private CharacterController _6cc9b126243967c42a13e9ca0e361dfd_dd2c6a10991443e580d90318525b3bb3_CommandTarget;

		private CharacterController _6cc9b126243967c42a13e9ca0e361dfd_d09455e4320242c598d45c371d01dcf2_CommandTarget;

		private CharacterController _6cc9b126243967c42a13e9ca0e361dfd_f7afe2e2ddec4b248949af1018a1ac2f_CommandTarget;

		private CharacterController _6cc9b126243967c42a13e9ca0e361dfd_67412d6490bb4661953529ca32b6594e_CommandTarget;

		private CharacterController _6cc9b126243967c42a13e9ca0e361dfd_86a6853c8a5741d88dcc512bd414b958_CommandTarget;

		private CharacterController _6cc9b126243967c42a13e9ca0e361dfd_327e0a4d13f04bb39c6d65263e157443_CommandTarget;

		private CharacterController _6cc9b126243967c42a13e9ca0e361dfd_1c6dfb56485244dd92c5354e0a6f1ee2_CommandTarget;

		private CharacterController _6cc9b126243967c42a13e9ca0e361dfd_3dd5514a24464c72aa859fc220272ff6_CommandTarget;

		private CharacterController _6cc9b126243967c42a13e9ca0e361dfd_9ec82904252844fdac0d23dcc92dbe67_CommandTarget;

		private CharacterController _6cc9b126243967c42a13e9ca0e361dfd_074af6540f744d28a7e853183d794b56_CommandTarget;

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

		private void BakeCommandBinding__6cc9b126243967c42a13e9ca0e361dfd_c6154915350342a6befc8966fece3054(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6cc9b126243967c42a13e9ca0e361dfd_c6154915350342a6befc8966fece3054(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6cc9b126243967c42a13e9ca0e361dfd_c6154915350342a6befc8966fece3054(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6cc9b126243967c42a13e9ca0e361dfd_c6154915350342a6befc8966fece3054(_6cc9b126243967c42a13e9ca0e361dfd_c6154915350342a6befc8966fece3054 command)
		{
		}

		private void BakeCommandBinding__6cc9b126243967c42a13e9ca0e361dfd_24483d6a494e43a1818fa9982e9cd307(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6cc9b126243967c42a13e9ca0e361dfd_24483d6a494e43a1818fa9982e9cd307(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6cc9b126243967c42a13e9ca0e361dfd_24483d6a494e43a1818fa9982e9cd307(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6cc9b126243967c42a13e9ca0e361dfd_24483d6a494e43a1818fa9982e9cd307(_6cc9b126243967c42a13e9ca0e361dfd_24483d6a494e43a1818fa9982e9cd307 command)
		{
		}

		private void BakeCommandBinding__6cc9b126243967c42a13e9ca0e361dfd_5a65dd76a28649c1bb19146751403ead(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6cc9b126243967c42a13e9ca0e361dfd_5a65dd76a28649c1bb19146751403ead(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6cc9b126243967c42a13e9ca0e361dfd_5a65dd76a28649c1bb19146751403ead(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6cc9b126243967c42a13e9ca0e361dfd_5a65dd76a28649c1bb19146751403ead(_6cc9b126243967c42a13e9ca0e361dfd_5a65dd76a28649c1bb19146751403ead command)
		{
		}

		private void BakeCommandBinding__6cc9b126243967c42a13e9ca0e361dfd_dd2c6a10991443e580d90318525b3bb3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6cc9b126243967c42a13e9ca0e361dfd_dd2c6a10991443e580d90318525b3bb3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6cc9b126243967c42a13e9ca0e361dfd_dd2c6a10991443e580d90318525b3bb3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6cc9b126243967c42a13e9ca0e361dfd_dd2c6a10991443e580d90318525b3bb3(_6cc9b126243967c42a13e9ca0e361dfd_dd2c6a10991443e580d90318525b3bb3 command)
		{
		}

		private void BakeCommandBinding__6cc9b126243967c42a13e9ca0e361dfd_d09455e4320242c598d45c371d01dcf2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6cc9b126243967c42a13e9ca0e361dfd_d09455e4320242c598d45c371d01dcf2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6cc9b126243967c42a13e9ca0e361dfd_d09455e4320242c598d45c371d01dcf2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6cc9b126243967c42a13e9ca0e361dfd_d09455e4320242c598d45c371d01dcf2(_6cc9b126243967c42a13e9ca0e361dfd_d09455e4320242c598d45c371d01dcf2 command)
		{
		}

		private void BakeCommandBinding__6cc9b126243967c42a13e9ca0e361dfd_f7afe2e2ddec4b248949af1018a1ac2f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6cc9b126243967c42a13e9ca0e361dfd_f7afe2e2ddec4b248949af1018a1ac2f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6cc9b126243967c42a13e9ca0e361dfd_f7afe2e2ddec4b248949af1018a1ac2f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6cc9b126243967c42a13e9ca0e361dfd_f7afe2e2ddec4b248949af1018a1ac2f(_6cc9b126243967c42a13e9ca0e361dfd_f7afe2e2ddec4b248949af1018a1ac2f command)
		{
		}

		private void BakeCommandBinding__6cc9b126243967c42a13e9ca0e361dfd_67412d6490bb4661953529ca32b6594e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6cc9b126243967c42a13e9ca0e361dfd_67412d6490bb4661953529ca32b6594e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6cc9b126243967c42a13e9ca0e361dfd_67412d6490bb4661953529ca32b6594e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6cc9b126243967c42a13e9ca0e361dfd_67412d6490bb4661953529ca32b6594e(_6cc9b126243967c42a13e9ca0e361dfd_67412d6490bb4661953529ca32b6594e command)
		{
		}

		private void BakeCommandBinding__6cc9b126243967c42a13e9ca0e361dfd_86a6853c8a5741d88dcc512bd414b958(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6cc9b126243967c42a13e9ca0e361dfd_86a6853c8a5741d88dcc512bd414b958(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6cc9b126243967c42a13e9ca0e361dfd_86a6853c8a5741d88dcc512bd414b958(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6cc9b126243967c42a13e9ca0e361dfd_86a6853c8a5741d88dcc512bd414b958(_6cc9b126243967c42a13e9ca0e361dfd_86a6853c8a5741d88dcc512bd414b958 command)
		{
		}

		private void BakeCommandBinding__6cc9b126243967c42a13e9ca0e361dfd_327e0a4d13f04bb39c6d65263e157443(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6cc9b126243967c42a13e9ca0e361dfd_327e0a4d13f04bb39c6d65263e157443(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6cc9b126243967c42a13e9ca0e361dfd_327e0a4d13f04bb39c6d65263e157443(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6cc9b126243967c42a13e9ca0e361dfd_327e0a4d13f04bb39c6d65263e157443(_6cc9b126243967c42a13e9ca0e361dfd_327e0a4d13f04bb39c6d65263e157443 command)
		{
		}

		private void BakeCommandBinding__6cc9b126243967c42a13e9ca0e361dfd_1c6dfb56485244dd92c5354e0a6f1ee2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6cc9b126243967c42a13e9ca0e361dfd_1c6dfb56485244dd92c5354e0a6f1ee2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6cc9b126243967c42a13e9ca0e361dfd_1c6dfb56485244dd92c5354e0a6f1ee2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6cc9b126243967c42a13e9ca0e361dfd_1c6dfb56485244dd92c5354e0a6f1ee2(_6cc9b126243967c42a13e9ca0e361dfd_1c6dfb56485244dd92c5354e0a6f1ee2 command)
		{
		}

		private void BakeCommandBinding__6cc9b126243967c42a13e9ca0e361dfd_3dd5514a24464c72aa859fc220272ff6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6cc9b126243967c42a13e9ca0e361dfd_3dd5514a24464c72aa859fc220272ff6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6cc9b126243967c42a13e9ca0e361dfd_3dd5514a24464c72aa859fc220272ff6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6cc9b126243967c42a13e9ca0e361dfd_3dd5514a24464c72aa859fc220272ff6(_6cc9b126243967c42a13e9ca0e361dfd_3dd5514a24464c72aa859fc220272ff6 command)
		{
		}

		private void BakeCommandBinding__6cc9b126243967c42a13e9ca0e361dfd_9ec82904252844fdac0d23dcc92dbe67(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6cc9b126243967c42a13e9ca0e361dfd_9ec82904252844fdac0d23dcc92dbe67(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6cc9b126243967c42a13e9ca0e361dfd_9ec82904252844fdac0d23dcc92dbe67(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6cc9b126243967c42a13e9ca0e361dfd_9ec82904252844fdac0d23dcc92dbe67(_6cc9b126243967c42a13e9ca0e361dfd_9ec82904252844fdac0d23dcc92dbe67 command)
		{
		}

		private void BakeCommandBinding__6cc9b126243967c42a13e9ca0e361dfd_074af6540f744d28a7e853183d794b56(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__6cc9b126243967c42a13e9ca0e361dfd_074af6540f744d28a7e853183d794b56(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__6cc9b126243967c42a13e9ca0e361dfd_074af6540f744d28a7e853183d794b56(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__6cc9b126243967c42a13e9ca0e361dfd_074af6540f744d28a7e853183d794b56(_6cc9b126243967c42a13e9ca0e361dfd_074af6540f744d28a7e853183d794b56 command)
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
