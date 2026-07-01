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
	public class CoherenceSync_e4973c43daf97ae4c84f3d3eebe8d531 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _e4973c43daf97ae4c84f3d3eebe8d531_6a6e7b6f5f3449238bdfc8af61116fdd_CommandTarget;

		private CharacterController _e4973c43daf97ae4c84f3d3eebe8d531_1ab4a960201c41bfad491580391beca8_CommandTarget;

		private CharacterController _e4973c43daf97ae4c84f3d3eebe8d531_bbeda3706e1c41029f28a7d80147c9a2_CommandTarget;

		private CharacterController _e4973c43daf97ae4c84f3d3eebe8d531_cb645ca9523f4005ba6ff25b7c9f24a3_CommandTarget;

		private CharacterController _e4973c43daf97ae4c84f3d3eebe8d531_af77a5a3f4a146cc9072075d1b6aa0b3_CommandTarget;

		private CharacterController _e4973c43daf97ae4c84f3d3eebe8d531_dc5e3a09b9d447038c8bb32231cc18cf_CommandTarget;

		private CharacterController _e4973c43daf97ae4c84f3d3eebe8d531_ca1caab907ee41b1a36098ff425e6c75_CommandTarget;

		private CharacterController _e4973c43daf97ae4c84f3d3eebe8d531_a19f4614517645849ed597dd80f8066f_CommandTarget;

		private CharacterController _e4973c43daf97ae4c84f3d3eebe8d531_3bad17aa3fd1447fbfe63389728098ab_CommandTarget;

		private CharacterController _e4973c43daf97ae4c84f3d3eebe8d531_4edd3f039faf470794e174b2a949ae32_CommandTarget;

		private CharacterController _e4973c43daf97ae4c84f3d3eebe8d531_2af36871fa034e8b965285d750e0c3cf_CommandTarget;

		private CharacterController _e4973c43daf97ae4c84f3d3eebe8d531_929f1520b6d641548e0f5788cf56456e_CommandTarget;

		private CharacterController _e4973c43daf97ae4c84f3d3eebe8d531_56ca385c6d2546a596fbd1942fa7a7c6_CommandTarget;

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

		private void BakeCommandBinding__e4973c43daf97ae4c84f3d3eebe8d531_6a6e7b6f5f3449238bdfc8af61116fdd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e4973c43daf97ae4c84f3d3eebe8d531_6a6e7b6f5f3449238bdfc8af61116fdd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e4973c43daf97ae4c84f3d3eebe8d531_6a6e7b6f5f3449238bdfc8af61116fdd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e4973c43daf97ae4c84f3d3eebe8d531_6a6e7b6f5f3449238bdfc8af61116fdd(_e4973c43daf97ae4c84f3d3eebe8d531_6a6e7b6f5f3449238bdfc8af61116fdd command)
		{
		}

		private void BakeCommandBinding__e4973c43daf97ae4c84f3d3eebe8d531_1ab4a960201c41bfad491580391beca8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e4973c43daf97ae4c84f3d3eebe8d531_1ab4a960201c41bfad491580391beca8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e4973c43daf97ae4c84f3d3eebe8d531_1ab4a960201c41bfad491580391beca8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e4973c43daf97ae4c84f3d3eebe8d531_1ab4a960201c41bfad491580391beca8(_e4973c43daf97ae4c84f3d3eebe8d531_1ab4a960201c41bfad491580391beca8 command)
		{
		}

		private void BakeCommandBinding__e4973c43daf97ae4c84f3d3eebe8d531_bbeda3706e1c41029f28a7d80147c9a2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e4973c43daf97ae4c84f3d3eebe8d531_bbeda3706e1c41029f28a7d80147c9a2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e4973c43daf97ae4c84f3d3eebe8d531_bbeda3706e1c41029f28a7d80147c9a2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e4973c43daf97ae4c84f3d3eebe8d531_bbeda3706e1c41029f28a7d80147c9a2(_e4973c43daf97ae4c84f3d3eebe8d531_bbeda3706e1c41029f28a7d80147c9a2 command)
		{
		}

		private void BakeCommandBinding__e4973c43daf97ae4c84f3d3eebe8d531_cb645ca9523f4005ba6ff25b7c9f24a3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e4973c43daf97ae4c84f3d3eebe8d531_cb645ca9523f4005ba6ff25b7c9f24a3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e4973c43daf97ae4c84f3d3eebe8d531_cb645ca9523f4005ba6ff25b7c9f24a3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e4973c43daf97ae4c84f3d3eebe8d531_cb645ca9523f4005ba6ff25b7c9f24a3(_e4973c43daf97ae4c84f3d3eebe8d531_cb645ca9523f4005ba6ff25b7c9f24a3 command)
		{
		}

		private void BakeCommandBinding__e4973c43daf97ae4c84f3d3eebe8d531_af77a5a3f4a146cc9072075d1b6aa0b3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e4973c43daf97ae4c84f3d3eebe8d531_af77a5a3f4a146cc9072075d1b6aa0b3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e4973c43daf97ae4c84f3d3eebe8d531_af77a5a3f4a146cc9072075d1b6aa0b3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e4973c43daf97ae4c84f3d3eebe8d531_af77a5a3f4a146cc9072075d1b6aa0b3(_e4973c43daf97ae4c84f3d3eebe8d531_af77a5a3f4a146cc9072075d1b6aa0b3 command)
		{
		}

		private void BakeCommandBinding__e4973c43daf97ae4c84f3d3eebe8d531_dc5e3a09b9d447038c8bb32231cc18cf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e4973c43daf97ae4c84f3d3eebe8d531_dc5e3a09b9d447038c8bb32231cc18cf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e4973c43daf97ae4c84f3d3eebe8d531_dc5e3a09b9d447038c8bb32231cc18cf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e4973c43daf97ae4c84f3d3eebe8d531_dc5e3a09b9d447038c8bb32231cc18cf(_e4973c43daf97ae4c84f3d3eebe8d531_dc5e3a09b9d447038c8bb32231cc18cf command)
		{
		}

		private void BakeCommandBinding__e4973c43daf97ae4c84f3d3eebe8d531_ca1caab907ee41b1a36098ff425e6c75(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e4973c43daf97ae4c84f3d3eebe8d531_ca1caab907ee41b1a36098ff425e6c75(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e4973c43daf97ae4c84f3d3eebe8d531_ca1caab907ee41b1a36098ff425e6c75(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e4973c43daf97ae4c84f3d3eebe8d531_ca1caab907ee41b1a36098ff425e6c75(_e4973c43daf97ae4c84f3d3eebe8d531_ca1caab907ee41b1a36098ff425e6c75 command)
		{
		}

		private void BakeCommandBinding__e4973c43daf97ae4c84f3d3eebe8d531_a19f4614517645849ed597dd80f8066f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e4973c43daf97ae4c84f3d3eebe8d531_a19f4614517645849ed597dd80f8066f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e4973c43daf97ae4c84f3d3eebe8d531_a19f4614517645849ed597dd80f8066f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e4973c43daf97ae4c84f3d3eebe8d531_a19f4614517645849ed597dd80f8066f(_e4973c43daf97ae4c84f3d3eebe8d531_a19f4614517645849ed597dd80f8066f command)
		{
		}

		private void BakeCommandBinding__e4973c43daf97ae4c84f3d3eebe8d531_3bad17aa3fd1447fbfe63389728098ab(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e4973c43daf97ae4c84f3d3eebe8d531_3bad17aa3fd1447fbfe63389728098ab(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e4973c43daf97ae4c84f3d3eebe8d531_3bad17aa3fd1447fbfe63389728098ab(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e4973c43daf97ae4c84f3d3eebe8d531_3bad17aa3fd1447fbfe63389728098ab(_e4973c43daf97ae4c84f3d3eebe8d531_3bad17aa3fd1447fbfe63389728098ab command)
		{
		}

		private void BakeCommandBinding__e4973c43daf97ae4c84f3d3eebe8d531_4edd3f039faf470794e174b2a949ae32(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e4973c43daf97ae4c84f3d3eebe8d531_4edd3f039faf470794e174b2a949ae32(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e4973c43daf97ae4c84f3d3eebe8d531_4edd3f039faf470794e174b2a949ae32(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e4973c43daf97ae4c84f3d3eebe8d531_4edd3f039faf470794e174b2a949ae32(_e4973c43daf97ae4c84f3d3eebe8d531_4edd3f039faf470794e174b2a949ae32 command)
		{
		}

		private void BakeCommandBinding__e4973c43daf97ae4c84f3d3eebe8d531_2af36871fa034e8b965285d750e0c3cf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e4973c43daf97ae4c84f3d3eebe8d531_2af36871fa034e8b965285d750e0c3cf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e4973c43daf97ae4c84f3d3eebe8d531_2af36871fa034e8b965285d750e0c3cf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e4973c43daf97ae4c84f3d3eebe8d531_2af36871fa034e8b965285d750e0c3cf(_e4973c43daf97ae4c84f3d3eebe8d531_2af36871fa034e8b965285d750e0c3cf command)
		{
		}

		private void BakeCommandBinding__e4973c43daf97ae4c84f3d3eebe8d531_929f1520b6d641548e0f5788cf56456e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e4973c43daf97ae4c84f3d3eebe8d531_929f1520b6d641548e0f5788cf56456e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e4973c43daf97ae4c84f3d3eebe8d531_929f1520b6d641548e0f5788cf56456e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e4973c43daf97ae4c84f3d3eebe8d531_929f1520b6d641548e0f5788cf56456e(_e4973c43daf97ae4c84f3d3eebe8d531_929f1520b6d641548e0f5788cf56456e command)
		{
		}

		private void BakeCommandBinding__e4973c43daf97ae4c84f3d3eebe8d531_56ca385c6d2546a596fbd1942fa7a7c6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__e4973c43daf97ae4c84f3d3eebe8d531_56ca385c6d2546a596fbd1942fa7a7c6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__e4973c43daf97ae4c84f3d3eebe8d531_56ca385c6d2546a596fbd1942fa7a7c6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__e4973c43daf97ae4c84f3d3eebe8d531_56ca385c6d2546a596fbd1942fa7a7c6(_e4973c43daf97ae4c84f3d3eebe8d531_56ca385c6d2546a596fbd1942fa7a7c6 command)
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
