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
	public class CoherenceSync_ba1c8b17e52bed441b02a3c7489360d2 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _ba1c8b17e52bed441b02a3c7489360d2_af62939bd33d47adbbb8cc3fd6bc1dcd_CommandTarget;

		private CharacterController _ba1c8b17e52bed441b02a3c7489360d2_5b6cf23311e54155accc1c718ac555f8_CommandTarget;

		private CharacterController _ba1c8b17e52bed441b02a3c7489360d2_f402a2b3650b47b19342057eb7a5b92e_CommandTarget;

		private CharacterController _ba1c8b17e52bed441b02a3c7489360d2_0bd3718c68754fd0818b952c9e4cc199_CommandTarget;

		private CharacterController _ba1c8b17e52bed441b02a3c7489360d2_527c5d634f384627b4795a34e6cbf7ee_CommandTarget;

		private CharacterController _ba1c8b17e52bed441b02a3c7489360d2_482dfe8270ad42e1ba1ad8e0f05d6c7a_CommandTarget;

		private CharacterController _ba1c8b17e52bed441b02a3c7489360d2_e0559a866d6e4a8a8df754b74c462716_CommandTarget;

		private CharacterController _ba1c8b17e52bed441b02a3c7489360d2_3b253b9510974374bc9c394593d37169_CommandTarget;

		private CharacterController _ba1c8b17e52bed441b02a3c7489360d2_72379852e2824c1db176d96322f7523f_CommandTarget;

		private CharacterController _ba1c8b17e52bed441b02a3c7489360d2_883e544f488349f4bf4f6638772819d9_CommandTarget;

		private CharacterController _ba1c8b17e52bed441b02a3c7489360d2_05e46daf5f1343da8c1f102f4ffbb33e_CommandTarget;

		private CharacterController _ba1c8b17e52bed441b02a3c7489360d2_80abd2ade0074e2babf11952a483c2df_CommandTarget;

		private CharacterController _ba1c8b17e52bed441b02a3c7489360d2_f48714279c364b2d85b8eb02675cb5bb_CommandTarget;

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

		private void BakeCommandBinding__ba1c8b17e52bed441b02a3c7489360d2_af62939bd33d47adbbb8cc3fd6bc1dcd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ba1c8b17e52bed441b02a3c7489360d2_af62939bd33d47adbbb8cc3fd6bc1dcd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ba1c8b17e52bed441b02a3c7489360d2_af62939bd33d47adbbb8cc3fd6bc1dcd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ba1c8b17e52bed441b02a3c7489360d2_af62939bd33d47adbbb8cc3fd6bc1dcd(_ba1c8b17e52bed441b02a3c7489360d2_af62939bd33d47adbbb8cc3fd6bc1dcd command)
		{
		}

		private void BakeCommandBinding__ba1c8b17e52bed441b02a3c7489360d2_5b6cf23311e54155accc1c718ac555f8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ba1c8b17e52bed441b02a3c7489360d2_5b6cf23311e54155accc1c718ac555f8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ba1c8b17e52bed441b02a3c7489360d2_5b6cf23311e54155accc1c718ac555f8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ba1c8b17e52bed441b02a3c7489360d2_5b6cf23311e54155accc1c718ac555f8(_ba1c8b17e52bed441b02a3c7489360d2_5b6cf23311e54155accc1c718ac555f8 command)
		{
		}

		private void BakeCommandBinding__ba1c8b17e52bed441b02a3c7489360d2_f402a2b3650b47b19342057eb7a5b92e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ba1c8b17e52bed441b02a3c7489360d2_f402a2b3650b47b19342057eb7a5b92e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ba1c8b17e52bed441b02a3c7489360d2_f402a2b3650b47b19342057eb7a5b92e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ba1c8b17e52bed441b02a3c7489360d2_f402a2b3650b47b19342057eb7a5b92e(_ba1c8b17e52bed441b02a3c7489360d2_f402a2b3650b47b19342057eb7a5b92e command)
		{
		}

		private void BakeCommandBinding__ba1c8b17e52bed441b02a3c7489360d2_0bd3718c68754fd0818b952c9e4cc199(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ba1c8b17e52bed441b02a3c7489360d2_0bd3718c68754fd0818b952c9e4cc199(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ba1c8b17e52bed441b02a3c7489360d2_0bd3718c68754fd0818b952c9e4cc199(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ba1c8b17e52bed441b02a3c7489360d2_0bd3718c68754fd0818b952c9e4cc199(_ba1c8b17e52bed441b02a3c7489360d2_0bd3718c68754fd0818b952c9e4cc199 command)
		{
		}

		private void BakeCommandBinding__ba1c8b17e52bed441b02a3c7489360d2_527c5d634f384627b4795a34e6cbf7ee(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ba1c8b17e52bed441b02a3c7489360d2_527c5d634f384627b4795a34e6cbf7ee(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ba1c8b17e52bed441b02a3c7489360d2_527c5d634f384627b4795a34e6cbf7ee(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ba1c8b17e52bed441b02a3c7489360d2_527c5d634f384627b4795a34e6cbf7ee(_ba1c8b17e52bed441b02a3c7489360d2_527c5d634f384627b4795a34e6cbf7ee command)
		{
		}

		private void BakeCommandBinding__ba1c8b17e52bed441b02a3c7489360d2_482dfe8270ad42e1ba1ad8e0f05d6c7a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ba1c8b17e52bed441b02a3c7489360d2_482dfe8270ad42e1ba1ad8e0f05d6c7a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ba1c8b17e52bed441b02a3c7489360d2_482dfe8270ad42e1ba1ad8e0f05d6c7a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ba1c8b17e52bed441b02a3c7489360d2_482dfe8270ad42e1ba1ad8e0f05d6c7a(_ba1c8b17e52bed441b02a3c7489360d2_482dfe8270ad42e1ba1ad8e0f05d6c7a command)
		{
		}

		private void BakeCommandBinding__ba1c8b17e52bed441b02a3c7489360d2_e0559a866d6e4a8a8df754b74c462716(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ba1c8b17e52bed441b02a3c7489360d2_e0559a866d6e4a8a8df754b74c462716(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ba1c8b17e52bed441b02a3c7489360d2_e0559a866d6e4a8a8df754b74c462716(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ba1c8b17e52bed441b02a3c7489360d2_e0559a866d6e4a8a8df754b74c462716(_ba1c8b17e52bed441b02a3c7489360d2_e0559a866d6e4a8a8df754b74c462716 command)
		{
		}

		private void BakeCommandBinding__ba1c8b17e52bed441b02a3c7489360d2_3b253b9510974374bc9c394593d37169(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ba1c8b17e52bed441b02a3c7489360d2_3b253b9510974374bc9c394593d37169(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ba1c8b17e52bed441b02a3c7489360d2_3b253b9510974374bc9c394593d37169(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ba1c8b17e52bed441b02a3c7489360d2_3b253b9510974374bc9c394593d37169(_ba1c8b17e52bed441b02a3c7489360d2_3b253b9510974374bc9c394593d37169 command)
		{
		}

		private void BakeCommandBinding__ba1c8b17e52bed441b02a3c7489360d2_72379852e2824c1db176d96322f7523f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ba1c8b17e52bed441b02a3c7489360d2_72379852e2824c1db176d96322f7523f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ba1c8b17e52bed441b02a3c7489360d2_72379852e2824c1db176d96322f7523f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ba1c8b17e52bed441b02a3c7489360d2_72379852e2824c1db176d96322f7523f(_ba1c8b17e52bed441b02a3c7489360d2_72379852e2824c1db176d96322f7523f command)
		{
		}

		private void BakeCommandBinding__ba1c8b17e52bed441b02a3c7489360d2_883e544f488349f4bf4f6638772819d9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ba1c8b17e52bed441b02a3c7489360d2_883e544f488349f4bf4f6638772819d9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ba1c8b17e52bed441b02a3c7489360d2_883e544f488349f4bf4f6638772819d9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ba1c8b17e52bed441b02a3c7489360d2_883e544f488349f4bf4f6638772819d9(_ba1c8b17e52bed441b02a3c7489360d2_883e544f488349f4bf4f6638772819d9 command)
		{
		}

		private void BakeCommandBinding__ba1c8b17e52bed441b02a3c7489360d2_05e46daf5f1343da8c1f102f4ffbb33e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ba1c8b17e52bed441b02a3c7489360d2_05e46daf5f1343da8c1f102f4ffbb33e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ba1c8b17e52bed441b02a3c7489360d2_05e46daf5f1343da8c1f102f4ffbb33e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ba1c8b17e52bed441b02a3c7489360d2_05e46daf5f1343da8c1f102f4ffbb33e(_ba1c8b17e52bed441b02a3c7489360d2_05e46daf5f1343da8c1f102f4ffbb33e command)
		{
		}

		private void BakeCommandBinding__ba1c8b17e52bed441b02a3c7489360d2_80abd2ade0074e2babf11952a483c2df(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ba1c8b17e52bed441b02a3c7489360d2_80abd2ade0074e2babf11952a483c2df(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ba1c8b17e52bed441b02a3c7489360d2_80abd2ade0074e2babf11952a483c2df(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ba1c8b17e52bed441b02a3c7489360d2_80abd2ade0074e2babf11952a483c2df(_ba1c8b17e52bed441b02a3c7489360d2_80abd2ade0074e2babf11952a483c2df command)
		{
		}

		private void BakeCommandBinding__ba1c8b17e52bed441b02a3c7489360d2_f48714279c364b2d85b8eb02675cb5bb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ba1c8b17e52bed441b02a3c7489360d2_f48714279c364b2d85b8eb02675cb5bb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ba1c8b17e52bed441b02a3c7489360d2_f48714279c364b2d85b8eb02675cb5bb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ba1c8b17e52bed441b02a3c7489360d2_f48714279c364b2d85b8eb02675cb5bb(_ba1c8b17e52bed441b02a3c7489360d2_f48714279c364b2d85b8eb02675cb5bb command)
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
