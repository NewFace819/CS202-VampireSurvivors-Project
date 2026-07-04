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
	public class CoherenceSync_428511d43dcea284a88597578067b45b : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _428511d43dcea284a88597578067b45b_5d6685a538574716bec3b84c2f9d0394_CommandTarget;

		private CharacterController _428511d43dcea284a88597578067b45b_a2ab5f6263e14a16b966333ce2ad1e40_CommandTarget;

		private CharacterController _428511d43dcea284a88597578067b45b_b7ddd2d2f89442929c6308156a019d68_CommandTarget;

		private CharacterController _428511d43dcea284a88597578067b45b_fb98618fbda84a1fac99def546c70e87_CommandTarget;

		private CharacterController _428511d43dcea284a88597578067b45b_9a95deefb5ad45b1b566d13eac5c1ac5_CommandTarget;

		private CharacterController _428511d43dcea284a88597578067b45b_0d8992ce97154a1cbbcae39d20701865_CommandTarget;

		private CharacterController _428511d43dcea284a88597578067b45b_4728f6c66aa24950b73bd00e6f5b1f4b_CommandTarget;

		private CharacterController _428511d43dcea284a88597578067b45b_967202b92a184e0a993bcef27ab3a65a_CommandTarget;

		private CharacterController _428511d43dcea284a88597578067b45b_cf9b2f580e224ee88be471d2aab38759_CommandTarget;

		private CharacterController _428511d43dcea284a88597578067b45b_9c1eb2a853c84a6f8422adc19c27e8a1_CommandTarget;

		private CharacterController _428511d43dcea284a88597578067b45b_2da94a7f4d2a4142a064a7a6b5618d3e_CommandTarget;

		private CharacterController _428511d43dcea284a88597578067b45b_be6c5a6d41a5402c98586b21f66231b2_CommandTarget;

		private CharacterController _428511d43dcea284a88597578067b45b_60b68286b6c24bd0873c6e301be2a70a_CommandTarget;

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

		private void BakeCommandBinding__428511d43dcea284a88597578067b45b_5d6685a538574716bec3b84c2f9d0394(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__428511d43dcea284a88597578067b45b_5d6685a538574716bec3b84c2f9d0394(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__428511d43dcea284a88597578067b45b_5d6685a538574716bec3b84c2f9d0394(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__428511d43dcea284a88597578067b45b_5d6685a538574716bec3b84c2f9d0394(_428511d43dcea284a88597578067b45b_5d6685a538574716bec3b84c2f9d0394 command)
		{
		}

		private void BakeCommandBinding__428511d43dcea284a88597578067b45b_a2ab5f6263e14a16b966333ce2ad1e40(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__428511d43dcea284a88597578067b45b_a2ab5f6263e14a16b966333ce2ad1e40(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__428511d43dcea284a88597578067b45b_a2ab5f6263e14a16b966333ce2ad1e40(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__428511d43dcea284a88597578067b45b_a2ab5f6263e14a16b966333ce2ad1e40(_428511d43dcea284a88597578067b45b_a2ab5f6263e14a16b966333ce2ad1e40 command)
		{
		}

		private void BakeCommandBinding__428511d43dcea284a88597578067b45b_b7ddd2d2f89442929c6308156a019d68(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__428511d43dcea284a88597578067b45b_b7ddd2d2f89442929c6308156a019d68(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__428511d43dcea284a88597578067b45b_b7ddd2d2f89442929c6308156a019d68(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__428511d43dcea284a88597578067b45b_b7ddd2d2f89442929c6308156a019d68(_428511d43dcea284a88597578067b45b_b7ddd2d2f89442929c6308156a019d68 command)
		{
		}

		private void BakeCommandBinding__428511d43dcea284a88597578067b45b_fb98618fbda84a1fac99def546c70e87(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__428511d43dcea284a88597578067b45b_fb98618fbda84a1fac99def546c70e87(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__428511d43dcea284a88597578067b45b_fb98618fbda84a1fac99def546c70e87(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__428511d43dcea284a88597578067b45b_fb98618fbda84a1fac99def546c70e87(_428511d43dcea284a88597578067b45b_fb98618fbda84a1fac99def546c70e87 command)
		{
		}

		private void BakeCommandBinding__428511d43dcea284a88597578067b45b_9a95deefb5ad45b1b566d13eac5c1ac5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__428511d43dcea284a88597578067b45b_9a95deefb5ad45b1b566d13eac5c1ac5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__428511d43dcea284a88597578067b45b_9a95deefb5ad45b1b566d13eac5c1ac5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__428511d43dcea284a88597578067b45b_9a95deefb5ad45b1b566d13eac5c1ac5(_428511d43dcea284a88597578067b45b_9a95deefb5ad45b1b566d13eac5c1ac5 command)
		{
		}

		private void BakeCommandBinding__428511d43dcea284a88597578067b45b_0d8992ce97154a1cbbcae39d20701865(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__428511d43dcea284a88597578067b45b_0d8992ce97154a1cbbcae39d20701865(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__428511d43dcea284a88597578067b45b_0d8992ce97154a1cbbcae39d20701865(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__428511d43dcea284a88597578067b45b_0d8992ce97154a1cbbcae39d20701865(_428511d43dcea284a88597578067b45b_0d8992ce97154a1cbbcae39d20701865 command)
		{
		}

		private void BakeCommandBinding__428511d43dcea284a88597578067b45b_4728f6c66aa24950b73bd00e6f5b1f4b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__428511d43dcea284a88597578067b45b_4728f6c66aa24950b73bd00e6f5b1f4b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__428511d43dcea284a88597578067b45b_4728f6c66aa24950b73bd00e6f5b1f4b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__428511d43dcea284a88597578067b45b_4728f6c66aa24950b73bd00e6f5b1f4b(_428511d43dcea284a88597578067b45b_4728f6c66aa24950b73bd00e6f5b1f4b command)
		{
		}

		private void BakeCommandBinding__428511d43dcea284a88597578067b45b_967202b92a184e0a993bcef27ab3a65a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__428511d43dcea284a88597578067b45b_967202b92a184e0a993bcef27ab3a65a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__428511d43dcea284a88597578067b45b_967202b92a184e0a993bcef27ab3a65a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__428511d43dcea284a88597578067b45b_967202b92a184e0a993bcef27ab3a65a(_428511d43dcea284a88597578067b45b_967202b92a184e0a993bcef27ab3a65a command)
		{
		}

		private void BakeCommandBinding__428511d43dcea284a88597578067b45b_cf9b2f580e224ee88be471d2aab38759(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__428511d43dcea284a88597578067b45b_cf9b2f580e224ee88be471d2aab38759(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__428511d43dcea284a88597578067b45b_cf9b2f580e224ee88be471d2aab38759(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__428511d43dcea284a88597578067b45b_cf9b2f580e224ee88be471d2aab38759(_428511d43dcea284a88597578067b45b_cf9b2f580e224ee88be471d2aab38759 command)
		{
		}

		private void BakeCommandBinding__428511d43dcea284a88597578067b45b_9c1eb2a853c84a6f8422adc19c27e8a1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__428511d43dcea284a88597578067b45b_9c1eb2a853c84a6f8422adc19c27e8a1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__428511d43dcea284a88597578067b45b_9c1eb2a853c84a6f8422adc19c27e8a1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__428511d43dcea284a88597578067b45b_9c1eb2a853c84a6f8422adc19c27e8a1(_428511d43dcea284a88597578067b45b_9c1eb2a853c84a6f8422adc19c27e8a1 command)
		{
		}

		private void BakeCommandBinding__428511d43dcea284a88597578067b45b_2da94a7f4d2a4142a064a7a6b5618d3e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__428511d43dcea284a88597578067b45b_2da94a7f4d2a4142a064a7a6b5618d3e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__428511d43dcea284a88597578067b45b_2da94a7f4d2a4142a064a7a6b5618d3e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__428511d43dcea284a88597578067b45b_2da94a7f4d2a4142a064a7a6b5618d3e(_428511d43dcea284a88597578067b45b_2da94a7f4d2a4142a064a7a6b5618d3e command)
		{
		}

		private void BakeCommandBinding__428511d43dcea284a88597578067b45b_be6c5a6d41a5402c98586b21f66231b2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__428511d43dcea284a88597578067b45b_be6c5a6d41a5402c98586b21f66231b2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__428511d43dcea284a88597578067b45b_be6c5a6d41a5402c98586b21f66231b2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__428511d43dcea284a88597578067b45b_be6c5a6d41a5402c98586b21f66231b2(_428511d43dcea284a88597578067b45b_be6c5a6d41a5402c98586b21f66231b2 command)
		{
		}

		private void BakeCommandBinding__428511d43dcea284a88597578067b45b_60b68286b6c24bd0873c6e301be2a70a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__428511d43dcea284a88597578067b45b_60b68286b6c24bd0873c6e301be2a70a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__428511d43dcea284a88597578067b45b_60b68286b6c24bd0873c6e301be2a70a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__428511d43dcea284a88597578067b45b_60b68286b6c24bd0873c6e301be2a70a(_428511d43dcea284a88597578067b45b_60b68286b6c24bd0873c6e301be2a70a command)
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
