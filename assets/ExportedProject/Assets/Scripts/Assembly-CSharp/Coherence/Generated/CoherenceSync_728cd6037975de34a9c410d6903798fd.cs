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
	public class CoherenceSync_728cd6037975de34a9c410d6903798fd : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _728cd6037975de34a9c410d6903798fd_1262688c42a740b6a766e341833de579_CommandTarget;

		private CharacterController _728cd6037975de34a9c410d6903798fd_3a8ee043f35f44ed923a588eb2f01bb0_CommandTarget;

		private CharacterController _728cd6037975de34a9c410d6903798fd_665c7db2d302417fa4a5670be154bb61_CommandTarget;

		private CharacterController _728cd6037975de34a9c410d6903798fd_d7fe04822e054abebb651782b27046f4_CommandTarget;

		private CharacterController _728cd6037975de34a9c410d6903798fd_4d241a05e895462bb563d43bb05eb889_CommandTarget;

		private CharacterController _728cd6037975de34a9c410d6903798fd_7dd1a7481fbf4e8dbddde760586ff6d5_CommandTarget;

		private CharacterController _728cd6037975de34a9c410d6903798fd_84666d1bb76e4f52b03cf3e593189463_CommandTarget;

		private CharacterController _728cd6037975de34a9c410d6903798fd_a46a0f0e829b479bae451db47a5bd006_CommandTarget;

		private CharacterController _728cd6037975de34a9c410d6903798fd_d334dad30e0e4ad79f6bb4a4a5aa5a8d_CommandTarget;

		private CharacterController _728cd6037975de34a9c410d6903798fd_e81da0223eb540d4a36e906dbfdd1695_CommandTarget;

		private CharacterController _728cd6037975de34a9c410d6903798fd_0f95d8dfa23840c681e904b2dc1ba09f_CommandTarget;

		private CharacterController _728cd6037975de34a9c410d6903798fd_cb7616b9dff840eba2b86fe561503a1b_CommandTarget;

		private CharacterController _728cd6037975de34a9c410d6903798fd_df3c62e04f0a41fe9adb1bc55f59a6fe_CommandTarget;

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

		private void BakeCommandBinding__728cd6037975de34a9c410d6903798fd_1262688c42a740b6a766e341833de579(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__728cd6037975de34a9c410d6903798fd_1262688c42a740b6a766e341833de579(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__728cd6037975de34a9c410d6903798fd_1262688c42a740b6a766e341833de579(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__728cd6037975de34a9c410d6903798fd_1262688c42a740b6a766e341833de579(_728cd6037975de34a9c410d6903798fd_1262688c42a740b6a766e341833de579 command)
		{
		}

		private void BakeCommandBinding__728cd6037975de34a9c410d6903798fd_3a8ee043f35f44ed923a588eb2f01bb0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__728cd6037975de34a9c410d6903798fd_3a8ee043f35f44ed923a588eb2f01bb0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__728cd6037975de34a9c410d6903798fd_3a8ee043f35f44ed923a588eb2f01bb0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__728cd6037975de34a9c410d6903798fd_3a8ee043f35f44ed923a588eb2f01bb0(_728cd6037975de34a9c410d6903798fd_3a8ee043f35f44ed923a588eb2f01bb0 command)
		{
		}

		private void BakeCommandBinding__728cd6037975de34a9c410d6903798fd_665c7db2d302417fa4a5670be154bb61(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__728cd6037975de34a9c410d6903798fd_665c7db2d302417fa4a5670be154bb61(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__728cd6037975de34a9c410d6903798fd_665c7db2d302417fa4a5670be154bb61(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__728cd6037975de34a9c410d6903798fd_665c7db2d302417fa4a5670be154bb61(_728cd6037975de34a9c410d6903798fd_665c7db2d302417fa4a5670be154bb61 command)
		{
		}

		private void BakeCommandBinding__728cd6037975de34a9c410d6903798fd_d7fe04822e054abebb651782b27046f4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__728cd6037975de34a9c410d6903798fd_d7fe04822e054abebb651782b27046f4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__728cd6037975de34a9c410d6903798fd_d7fe04822e054abebb651782b27046f4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__728cd6037975de34a9c410d6903798fd_d7fe04822e054abebb651782b27046f4(_728cd6037975de34a9c410d6903798fd_d7fe04822e054abebb651782b27046f4 command)
		{
		}

		private void BakeCommandBinding__728cd6037975de34a9c410d6903798fd_4d241a05e895462bb563d43bb05eb889(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__728cd6037975de34a9c410d6903798fd_4d241a05e895462bb563d43bb05eb889(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__728cd6037975de34a9c410d6903798fd_4d241a05e895462bb563d43bb05eb889(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__728cd6037975de34a9c410d6903798fd_4d241a05e895462bb563d43bb05eb889(_728cd6037975de34a9c410d6903798fd_4d241a05e895462bb563d43bb05eb889 command)
		{
		}

		private void BakeCommandBinding__728cd6037975de34a9c410d6903798fd_7dd1a7481fbf4e8dbddde760586ff6d5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__728cd6037975de34a9c410d6903798fd_7dd1a7481fbf4e8dbddde760586ff6d5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__728cd6037975de34a9c410d6903798fd_7dd1a7481fbf4e8dbddde760586ff6d5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__728cd6037975de34a9c410d6903798fd_7dd1a7481fbf4e8dbddde760586ff6d5(_728cd6037975de34a9c410d6903798fd_7dd1a7481fbf4e8dbddde760586ff6d5 command)
		{
		}

		private void BakeCommandBinding__728cd6037975de34a9c410d6903798fd_84666d1bb76e4f52b03cf3e593189463(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__728cd6037975de34a9c410d6903798fd_84666d1bb76e4f52b03cf3e593189463(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__728cd6037975de34a9c410d6903798fd_84666d1bb76e4f52b03cf3e593189463(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__728cd6037975de34a9c410d6903798fd_84666d1bb76e4f52b03cf3e593189463(_728cd6037975de34a9c410d6903798fd_84666d1bb76e4f52b03cf3e593189463 command)
		{
		}

		private void BakeCommandBinding__728cd6037975de34a9c410d6903798fd_a46a0f0e829b479bae451db47a5bd006(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__728cd6037975de34a9c410d6903798fd_a46a0f0e829b479bae451db47a5bd006(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__728cd6037975de34a9c410d6903798fd_a46a0f0e829b479bae451db47a5bd006(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__728cd6037975de34a9c410d6903798fd_a46a0f0e829b479bae451db47a5bd006(_728cd6037975de34a9c410d6903798fd_a46a0f0e829b479bae451db47a5bd006 command)
		{
		}

		private void BakeCommandBinding__728cd6037975de34a9c410d6903798fd_d334dad30e0e4ad79f6bb4a4a5aa5a8d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__728cd6037975de34a9c410d6903798fd_d334dad30e0e4ad79f6bb4a4a5aa5a8d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__728cd6037975de34a9c410d6903798fd_d334dad30e0e4ad79f6bb4a4a5aa5a8d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__728cd6037975de34a9c410d6903798fd_d334dad30e0e4ad79f6bb4a4a5aa5a8d(_728cd6037975de34a9c410d6903798fd_d334dad30e0e4ad79f6bb4a4a5aa5a8d command)
		{
		}

		private void BakeCommandBinding__728cd6037975de34a9c410d6903798fd_e81da0223eb540d4a36e906dbfdd1695(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__728cd6037975de34a9c410d6903798fd_e81da0223eb540d4a36e906dbfdd1695(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__728cd6037975de34a9c410d6903798fd_e81da0223eb540d4a36e906dbfdd1695(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__728cd6037975de34a9c410d6903798fd_e81da0223eb540d4a36e906dbfdd1695(_728cd6037975de34a9c410d6903798fd_e81da0223eb540d4a36e906dbfdd1695 command)
		{
		}

		private void BakeCommandBinding__728cd6037975de34a9c410d6903798fd_0f95d8dfa23840c681e904b2dc1ba09f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__728cd6037975de34a9c410d6903798fd_0f95d8dfa23840c681e904b2dc1ba09f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__728cd6037975de34a9c410d6903798fd_0f95d8dfa23840c681e904b2dc1ba09f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__728cd6037975de34a9c410d6903798fd_0f95d8dfa23840c681e904b2dc1ba09f(_728cd6037975de34a9c410d6903798fd_0f95d8dfa23840c681e904b2dc1ba09f command)
		{
		}

		private void BakeCommandBinding__728cd6037975de34a9c410d6903798fd_cb7616b9dff840eba2b86fe561503a1b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__728cd6037975de34a9c410d6903798fd_cb7616b9dff840eba2b86fe561503a1b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__728cd6037975de34a9c410d6903798fd_cb7616b9dff840eba2b86fe561503a1b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__728cd6037975de34a9c410d6903798fd_cb7616b9dff840eba2b86fe561503a1b(_728cd6037975de34a9c410d6903798fd_cb7616b9dff840eba2b86fe561503a1b command)
		{
		}

		private void BakeCommandBinding__728cd6037975de34a9c410d6903798fd_df3c62e04f0a41fe9adb1bc55f59a6fe(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__728cd6037975de34a9c410d6903798fd_df3c62e04f0a41fe9adb1bc55f59a6fe(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__728cd6037975de34a9c410d6903798fd_df3c62e04f0a41fe9adb1bc55f59a6fe(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__728cd6037975de34a9c410d6903798fd_df3c62e04f0a41fe9adb1bc55f59a6fe(_728cd6037975de34a9c410d6903798fd_df3c62e04f0a41fe9adb1bc55f59a6fe command)
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
