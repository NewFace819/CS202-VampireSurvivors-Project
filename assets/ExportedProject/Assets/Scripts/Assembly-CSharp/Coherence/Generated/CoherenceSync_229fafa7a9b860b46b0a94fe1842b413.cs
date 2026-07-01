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
	public class CoherenceSync_229fafa7a9b860b46b0a94fe1842b413 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _229fafa7a9b860b46b0a94fe1842b413_f1924ebbb6f14d0bbf3adf4b74e3da40_CommandTarget;

		private CharacterController _229fafa7a9b860b46b0a94fe1842b413_b32cdca514b9430e9c67d4a5727d1ed9_CommandTarget;

		private CharacterController _229fafa7a9b860b46b0a94fe1842b413_ba403497489c44aea3d64e84602a0587_CommandTarget;

		private CharacterController _229fafa7a9b860b46b0a94fe1842b413_c1c59bd8076d49a8bb3da4ad6f93f88a_CommandTarget;

		private CharacterController _229fafa7a9b860b46b0a94fe1842b413_9a8251ae0dd94f59a94e0e3aed2daf1e_CommandTarget;

		private CharacterController _229fafa7a9b860b46b0a94fe1842b413_6a45827b83a2463392417fccf202cac1_CommandTarget;

		private CharacterController _229fafa7a9b860b46b0a94fe1842b413_4e5d90e2443f499695955121035dde52_CommandTarget;

		private CharacterController _229fafa7a9b860b46b0a94fe1842b413_6bf523a26df940d68265cf255ae0bef5_CommandTarget;

		private CharacterController _229fafa7a9b860b46b0a94fe1842b413_df20cc4270e3410c9feace20647ff460_CommandTarget;

		private CharacterController _229fafa7a9b860b46b0a94fe1842b413_7380fd96ef054950890530c94b138004_CommandTarget;

		private CharacterController _229fafa7a9b860b46b0a94fe1842b413_f7a991b839f9433681908ca09a995360_CommandTarget;

		private CharacterController _229fafa7a9b860b46b0a94fe1842b413_dfabee9c47094a88be1023be9d4ea879_CommandTarget;

		private CharacterController _229fafa7a9b860b46b0a94fe1842b413_0fca3fd8511543d5aa53a71d06042c73_CommandTarget;

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

		private void BakeCommandBinding__229fafa7a9b860b46b0a94fe1842b413_f1924ebbb6f14d0bbf3adf4b74e3da40(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__229fafa7a9b860b46b0a94fe1842b413_f1924ebbb6f14d0bbf3adf4b74e3da40(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__229fafa7a9b860b46b0a94fe1842b413_f1924ebbb6f14d0bbf3adf4b74e3da40(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__229fafa7a9b860b46b0a94fe1842b413_f1924ebbb6f14d0bbf3adf4b74e3da40(_229fafa7a9b860b46b0a94fe1842b413_f1924ebbb6f14d0bbf3adf4b74e3da40 command)
		{
		}

		private void BakeCommandBinding__229fafa7a9b860b46b0a94fe1842b413_b32cdca514b9430e9c67d4a5727d1ed9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__229fafa7a9b860b46b0a94fe1842b413_b32cdca514b9430e9c67d4a5727d1ed9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__229fafa7a9b860b46b0a94fe1842b413_b32cdca514b9430e9c67d4a5727d1ed9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__229fafa7a9b860b46b0a94fe1842b413_b32cdca514b9430e9c67d4a5727d1ed9(_229fafa7a9b860b46b0a94fe1842b413_b32cdca514b9430e9c67d4a5727d1ed9 command)
		{
		}

		private void BakeCommandBinding__229fafa7a9b860b46b0a94fe1842b413_ba403497489c44aea3d64e84602a0587(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__229fafa7a9b860b46b0a94fe1842b413_ba403497489c44aea3d64e84602a0587(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__229fafa7a9b860b46b0a94fe1842b413_ba403497489c44aea3d64e84602a0587(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__229fafa7a9b860b46b0a94fe1842b413_ba403497489c44aea3d64e84602a0587(_229fafa7a9b860b46b0a94fe1842b413_ba403497489c44aea3d64e84602a0587 command)
		{
		}

		private void BakeCommandBinding__229fafa7a9b860b46b0a94fe1842b413_c1c59bd8076d49a8bb3da4ad6f93f88a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__229fafa7a9b860b46b0a94fe1842b413_c1c59bd8076d49a8bb3da4ad6f93f88a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__229fafa7a9b860b46b0a94fe1842b413_c1c59bd8076d49a8bb3da4ad6f93f88a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__229fafa7a9b860b46b0a94fe1842b413_c1c59bd8076d49a8bb3da4ad6f93f88a(_229fafa7a9b860b46b0a94fe1842b413_c1c59bd8076d49a8bb3da4ad6f93f88a command)
		{
		}

		private void BakeCommandBinding__229fafa7a9b860b46b0a94fe1842b413_9a8251ae0dd94f59a94e0e3aed2daf1e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__229fafa7a9b860b46b0a94fe1842b413_9a8251ae0dd94f59a94e0e3aed2daf1e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__229fafa7a9b860b46b0a94fe1842b413_9a8251ae0dd94f59a94e0e3aed2daf1e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__229fafa7a9b860b46b0a94fe1842b413_9a8251ae0dd94f59a94e0e3aed2daf1e(_229fafa7a9b860b46b0a94fe1842b413_9a8251ae0dd94f59a94e0e3aed2daf1e command)
		{
		}

		private void BakeCommandBinding__229fafa7a9b860b46b0a94fe1842b413_6a45827b83a2463392417fccf202cac1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__229fafa7a9b860b46b0a94fe1842b413_6a45827b83a2463392417fccf202cac1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__229fafa7a9b860b46b0a94fe1842b413_6a45827b83a2463392417fccf202cac1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__229fafa7a9b860b46b0a94fe1842b413_6a45827b83a2463392417fccf202cac1(_229fafa7a9b860b46b0a94fe1842b413_6a45827b83a2463392417fccf202cac1 command)
		{
		}

		private void BakeCommandBinding__229fafa7a9b860b46b0a94fe1842b413_4e5d90e2443f499695955121035dde52(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__229fafa7a9b860b46b0a94fe1842b413_4e5d90e2443f499695955121035dde52(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__229fafa7a9b860b46b0a94fe1842b413_4e5d90e2443f499695955121035dde52(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__229fafa7a9b860b46b0a94fe1842b413_4e5d90e2443f499695955121035dde52(_229fafa7a9b860b46b0a94fe1842b413_4e5d90e2443f499695955121035dde52 command)
		{
		}

		private void BakeCommandBinding__229fafa7a9b860b46b0a94fe1842b413_6bf523a26df940d68265cf255ae0bef5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__229fafa7a9b860b46b0a94fe1842b413_6bf523a26df940d68265cf255ae0bef5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__229fafa7a9b860b46b0a94fe1842b413_6bf523a26df940d68265cf255ae0bef5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__229fafa7a9b860b46b0a94fe1842b413_6bf523a26df940d68265cf255ae0bef5(_229fafa7a9b860b46b0a94fe1842b413_6bf523a26df940d68265cf255ae0bef5 command)
		{
		}

		private void BakeCommandBinding__229fafa7a9b860b46b0a94fe1842b413_df20cc4270e3410c9feace20647ff460(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__229fafa7a9b860b46b0a94fe1842b413_df20cc4270e3410c9feace20647ff460(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__229fafa7a9b860b46b0a94fe1842b413_df20cc4270e3410c9feace20647ff460(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__229fafa7a9b860b46b0a94fe1842b413_df20cc4270e3410c9feace20647ff460(_229fafa7a9b860b46b0a94fe1842b413_df20cc4270e3410c9feace20647ff460 command)
		{
		}

		private void BakeCommandBinding__229fafa7a9b860b46b0a94fe1842b413_7380fd96ef054950890530c94b138004(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__229fafa7a9b860b46b0a94fe1842b413_7380fd96ef054950890530c94b138004(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__229fafa7a9b860b46b0a94fe1842b413_7380fd96ef054950890530c94b138004(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__229fafa7a9b860b46b0a94fe1842b413_7380fd96ef054950890530c94b138004(_229fafa7a9b860b46b0a94fe1842b413_7380fd96ef054950890530c94b138004 command)
		{
		}

		private void BakeCommandBinding__229fafa7a9b860b46b0a94fe1842b413_f7a991b839f9433681908ca09a995360(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__229fafa7a9b860b46b0a94fe1842b413_f7a991b839f9433681908ca09a995360(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__229fafa7a9b860b46b0a94fe1842b413_f7a991b839f9433681908ca09a995360(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__229fafa7a9b860b46b0a94fe1842b413_f7a991b839f9433681908ca09a995360(_229fafa7a9b860b46b0a94fe1842b413_f7a991b839f9433681908ca09a995360 command)
		{
		}

		private void BakeCommandBinding__229fafa7a9b860b46b0a94fe1842b413_dfabee9c47094a88be1023be9d4ea879(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__229fafa7a9b860b46b0a94fe1842b413_dfabee9c47094a88be1023be9d4ea879(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__229fafa7a9b860b46b0a94fe1842b413_dfabee9c47094a88be1023be9d4ea879(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__229fafa7a9b860b46b0a94fe1842b413_dfabee9c47094a88be1023be9d4ea879(_229fafa7a9b860b46b0a94fe1842b413_dfabee9c47094a88be1023be9d4ea879 command)
		{
		}

		private void BakeCommandBinding__229fafa7a9b860b46b0a94fe1842b413_0fca3fd8511543d5aa53a71d06042c73(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__229fafa7a9b860b46b0a94fe1842b413_0fca3fd8511543d5aa53a71d06042c73(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__229fafa7a9b860b46b0a94fe1842b413_0fca3fd8511543d5aa53a71d06042c73(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__229fafa7a9b860b46b0a94fe1842b413_0fca3fd8511543d5aa53a71d06042c73(_229fafa7a9b860b46b0a94fe1842b413_0fca3fd8511543d5aa53a71d06042c73 command)
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
