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
	public class CoherenceSync_f00b860cbd5487747b5122cbb3cd690a : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _f00b860cbd5487747b5122cbb3cd690a_825321330dfb43a7a81f5d1397564ba6_CommandTarget;

		private CharacterController _f00b860cbd5487747b5122cbb3cd690a_7294d47fb01941b0896c63aafe997d32_CommandTarget;

		private CharacterController _f00b860cbd5487747b5122cbb3cd690a_f0b446aa860f41d28cc9e6f48d3e2b9b_CommandTarget;

		private CharacterController _f00b860cbd5487747b5122cbb3cd690a_17c3e9c9793b441cb331c4fcc84f13da_CommandTarget;

		private CharacterController _f00b860cbd5487747b5122cbb3cd690a_1af668e75a2e49e2adf61bd21bb8e5a2_CommandTarget;

		private CharacterController _f00b860cbd5487747b5122cbb3cd690a_662c0588c9c9446d9595dad3f80c9ba2_CommandTarget;

		private CharacterController _f00b860cbd5487747b5122cbb3cd690a_3f16005c6e72447d8c5acbc126714068_CommandTarget;

		private CharacterController _f00b860cbd5487747b5122cbb3cd690a_c1c69d13c2204033bbe6a15e25318daf_CommandTarget;

		private CharacterController _f00b860cbd5487747b5122cbb3cd690a_d505cc3678b14a1185c2e9ba164067f0_CommandTarget;

		private CharacterController _f00b860cbd5487747b5122cbb3cd690a_93bad5d55c064d1a9ca0ce58cfa1f8b5_CommandTarget;

		private CharacterController _f00b860cbd5487747b5122cbb3cd690a_8e523f9cef2e4c0c95d28e5203b65d8e_CommandTarget;

		private CharacterController _f00b860cbd5487747b5122cbb3cd690a_35b8faadcda348d98f399766aa8b5e7c_CommandTarget;

		private CharacterController _f00b860cbd5487747b5122cbb3cd690a_9290e68193544572a9d2a056fd3a829d_CommandTarget;

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

		private void BakeCommandBinding__f00b860cbd5487747b5122cbb3cd690a_825321330dfb43a7a81f5d1397564ba6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f00b860cbd5487747b5122cbb3cd690a_825321330dfb43a7a81f5d1397564ba6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f00b860cbd5487747b5122cbb3cd690a_825321330dfb43a7a81f5d1397564ba6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f00b860cbd5487747b5122cbb3cd690a_825321330dfb43a7a81f5d1397564ba6(_f00b860cbd5487747b5122cbb3cd690a_825321330dfb43a7a81f5d1397564ba6 command)
		{
		}

		private void BakeCommandBinding__f00b860cbd5487747b5122cbb3cd690a_7294d47fb01941b0896c63aafe997d32(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f00b860cbd5487747b5122cbb3cd690a_7294d47fb01941b0896c63aafe997d32(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f00b860cbd5487747b5122cbb3cd690a_7294d47fb01941b0896c63aafe997d32(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f00b860cbd5487747b5122cbb3cd690a_7294d47fb01941b0896c63aafe997d32(_f00b860cbd5487747b5122cbb3cd690a_7294d47fb01941b0896c63aafe997d32 command)
		{
		}

		private void BakeCommandBinding__f00b860cbd5487747b5122cbb3cd690a_f0b446aa860f41d28cc9e6f48d3e2b9b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f00b860cbd5487747b5122cbb3cd690a_f0b446aa860f41d28cc9e6f48d3e2b9b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f00b860cbd5487747b5122cbb3cd690a_f0b446aa860f41d28cc9e6f48d3e2b9b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f00b860cbd5487747b5122cbb3cd690a_f0b446aa860f41d28cc9e6f48d3e2b9b(_f00b860cbd5487747b5122cbb3cd690a_f0b446aa860f41d28cc9e6f48d3e2b9b command)
		{
		}

		private void BakeCommandBinding__f00b860cbd5487747b5122cbb3cd690a_17c3e9c9793b441cb331c4fcc84f13da(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f00b860cbd5487747b5122cbb3cd690a_17c3e9c9793b441cb331c4fcc84f13da(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f00b860cbd5487747b5122cbb3cd690a_17c3e9c9793b441cb331c4fcc84f13da(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f00b860cbd5487747b5122cbb3cd690a_17c3e9c9793b441cb331c4fcc84f13da(_f00b860cbd5487747b5122cbb3cd690a_17c3e9c9793b441cb331c4fcc84f13da command)
		{
		}

		private void BakeCommandBinding__f00b860cbd5487747b5122cbb3cd690a_1af668e75a2e49e2adf61bd21bb8e5a2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f00b860cbd5487747b5122cbb3cd690a_1af668e75a2e49e2adf61bd21bb8e5a2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f00b860cbd5487747b5122cbb3cd690a_1af668e75a2e49e2adf61bd21bb8e5a2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f00b860cbd5487747b5122cbb3cd690a_1af668e75a2e49e2adf61bd21bb8e5a2(_f00b860cbd5487747b5122cbb3cd690a_1af668e75a2e49e2adf61bd21bb8e5a2 command)
		{
		}

		private void BakeCommandBinding__f00b860cbd5487747b5122cbb3cd690a_662c0588c9c9446d9595dad3f80c9ba2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f00b860cbd5487747b5122cbb3cd690a_662c0588c9c9446d9595dad3f80c9ba2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f00b860cbd5487747b5122cbb3cd690a_662c0588c9c9446d9595dad3f80c9ba2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f00b860cbd5487747b5122cbb3cd690a_662c0588c9c9446d9595dad3f80c9ba2(_f00b860cbd5487747b5122cbb3cd690a_662c0588c9c9446d9595dad3f80c9ba2 command)
		{
		}

		private void BakeCommandBinding__f00b860cbd5487747b5122cbb3cd690a_3f16005c6e72447d8c5acbc126714068(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f00b860cbd5487747b5122cbb3cd690a_3f16005c6e72447d8c5acbc126714068(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f00b860cbd5487747b5122cbb3cd690a_3f16005c6e72447d8c5acbc126714068(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f00b860cbd5487747b5122cbb3cd690a_3f16005c6e72447d8c5acbc126714068(_f00b860cbd5487747b5122cbb3cd690a_3f16005c6e72447d8c5acbc126714068 command)
		{
		}

		private void BakeCommandBinding__f00b860cbd5487747b5122cbb3cd690a_c1c69d13c2204033bbe6a15e25318daf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f00b860cbd5487747b5122cbb3cd690a_c1c69d13c2204033bbe6a15e25318daf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f00b860cbd5487747b5122cbb3cd690a_c1c69d13c2204033bbe6a15e25318daf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f00b860cbd5487747b5122cbb3cd690a_c1c69d13c2204033bbe6a15e25318daf(_f00b860cbd5487747b5122cbb3cd690a_c1c69d13c2204033bbe6a15e25318daf command)
		{
		}

		private void BakeCommandBinding__f00b860cbd5487747b5122cbb3cd690a_d505cc3678b14a1185c2e9ba164067f0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f00b860cbd5487747b5122cbb3cd690a_d505cc3678b14a1185c2e9ba164067f0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f00b860cbd5487747b5122cbb3cd690a_d505cc3678b14a1185c2e9ba164067f0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f00b860cbd5487747b5122cbb3cd690a_d505cc3678b14a1185c2e9ba164067f0(_f00b860cbd5487747b5122cbb3cd690a_d505cc3678b14a1185c2e9ba164067f0 command)
		{
		}

		private void BakeCommandBinding__f00b860cbd5487747b5122cbb3cd690a_93bad5d55c064d1a9ca0ce58cfa1f8b5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f00b860cbd5487747b5122cbb3cd690a_93bad5d55c064d1a9ca0ce58cfa1f8b5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f00b860cbd5487747b5122cbb3cd690a_93bad5d55c064d1a9ca0ce58cfa1f8b5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f00b860cbd5487747b5122cbb3cd690a_93bad5d55c064d1a9ca0ce58cfa1f8b5(_f00b860cbd5487747b5122cbb3cd690a_93bad5d55c064d1a9ca0ce58cfa1f8b5 command)
		{
		}

		private void BakeCommandBinding__f00b860cbd5487747b5122cbb3cd690a_8e523f9cef2e4c0c95d28e5203b65d8e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f00b860cbd5487747b5122cbb3cd690a_8e523f9cef2e4c0c95d28e5203b65d8e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f00b860cbd5487747b5122cbb3cd690a_8e523f9cef2e4c0c95d28e5203b65d8e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f00b860cbd5487747b5122cbb3cd690a_8e523f9cef2e4c0c95d28e5203b65d8e(_f00b860cbd5487747b5122cbb3cd690a_8e523f9cef2e4c0c95d28e5203b65d8e command)
		{
		}

		private void BakeCommandBinding__f00b860cbd5487747b5122cbb3cd690a_35b8faadcda348d98f399766aa8b5e7c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f00b860cbd5487747b5122cbb3cd690a_35b8faadcda348d98f399766aa8b5e7c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f00b860cbd5487747b5122cbb3cd690a_35b8faadcda348d98f399766aa8b5e7c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f00b860cbd5487747b5122cbb3cd690a_35b8faadcda348d98f399766aa8b5e7c(_f00b860cbd5487747b5122cbb3cd690a_35b8faadcda348d98f399766aa8b5e7c command)
		{
		}

		private void BakeCommandBinding__f00b860cbd5487747b5122cbb3cd690a_9290e68193544572a9d2a056fd3a829d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__f00b860cbd5487747b5122cbb3cd690a_9290e68193544572a9d2a056fd3a829d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__f00b860cbd5487747b5122cbb3cd690a_9290e68193544572a9d2a056fd3a829d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__f00b860cbd5487747b5122cbb3cd690a_9290e68193544572a9d2a056fd3a829d(_f00b860cbd5487747b5122cbb3cd690a_9290e68193544572a9d2a056fd3a829d command)
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
