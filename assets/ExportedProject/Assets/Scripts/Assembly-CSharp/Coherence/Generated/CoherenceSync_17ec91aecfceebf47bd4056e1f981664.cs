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
	public class CoherenceSync_17ec91aecfceebf47bd4056e1f981664 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _17ec91aecfceebf47bd4056e1f981664_134aacdbd1c8496baba550352c0d4f85_CommandTarget;

		private CharacterController _17ec91aecfceebf47bd4056e1f981664_fe6dc85f11124200a431228df60b3906_CommandTarget;

		private CharacterController _17ec91aecfceebf47bd4056e1f981664_4a89b22a6edc42c9bcf84cc22ff00bd9_CommandTarget;

		private CharacterController _17ec91aecfceebf47bd4056e1f981664_a03688cf30114b2e8d8aa1c815bcd036_CommandTarget;

		private CharacterController _17ec91aecfceebf47bd4056e1f981664_b4b89d3564924c1d9adb611ec3210553_CommandTarget;

		private CharacterController _17ec91aecfceebf47bd4056e1f981664_6eb3b60792c14d79bdf7dc21e5380f09_CommandTarget;

		private CharacterController _17ec91aecfceebf47bd4056e1f981664_4c1ee87bfbad4085bf9198f1bdf4d8a2_CommandTarget;

		private CharacterController _17ec91aecfceebf47bd4056e1f981664_f853fabc3d284dc19bb4e858004c7320_CommandTarget;

		private CharacterController _17ec91aecfceebf47bd4056e1f981664_52637e0eb42d49c298b52b659eae94c1_CommandTarget;

		private CharacterController _17ec91aecfceebf47bd4056e1f981664_e36a41b6aea64d8db3537b02bfe89cb6_CommandTarget;

		private CharacterController _17ec91aecfceebf47bd4056e1f981664_a340c600d56c47b0bf07c4298051c0b7_CommandTarget;

		private CharacterController _17ec91aecfceebf47bd4056e1f981664_2506270c71484cb69f1cad552bf406e0_CommandTarget;

		private CharacterController _17ec91aecfceebf47bd4056e1f981664_d54de59d26c94d7d8e464898fffa22f0_CommandTarget;

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

		private void BakeCommandBinding__17ec91aecfceebf47bd4056e1f981664_134aacdbd1c8496baba550352c0d4f85(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__17ec91aecfceebf47bd4056e1f981664_134aacdbd1c8496baba550352c0d4f85(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__17ec91aecfceebf47bd4056e1f981664_134aacdbd1c8496baba550352c0d4f85(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__17ec91aecfceebf47bd4056e1f981664_134aacdbd1c8496baba550352c0d4f85(_17ec91aecfceebf47bd4056e1f981664_134aacdbd1c8496baba550352c0d4f85 command)
		{
		}

		private void BakeCommandBinding__17ec91aecfceebf47bd4056e1f981664_fe6dc85f11124200a431228df60b3906(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__17ec91aecfceebf47bd4056e1f981664_fe6dc85f11124200a431228df60b3906(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__17ec91aecfceebf47bd4056e1f981664_fe6dc85f11124200a431228df60b3906(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__17ec91aecfceebf47bd4056e1f981664_fe6dc85f11124200a431228df60b3906(_17ec91aecfceebf47bd4056e1f981664_fe6dc85f11124200a431228df60b3906 command)
		{
		}

		private void BakeCommandBinding__17ec91aecfceebf47bd4056e1f981664_4a89b22a6edc42c9bcf84cc22ff00bd9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__17ec91aecfceebf47bd4056e1f981664_4a89b22a6edc42c9bcf84cc22ff00bd9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__17ec91aecfceebf47bd4056e1f981664_4a89b22a6edc42c9bcf84cc22ff00bd9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__17ec91aecfceebf47bd4056e1f981664_4a89b22a6edc42c9bcf84cc22ff00bd9(_17ec91aecfceebf47bd4056e1f981664_4a89b22a6edc42c9bcf84cc22ff00bd9 command)
		{
		}

		private void BakeCommandBinding__17ec91aecfceebf47bd4056e1f981664_a03688cf30114b2e8d8aa1c815bcd036(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__17ec91aecfceebf47bd4056e1f981664_a03688cf30114b2e8d8aa1c815bcd036(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__17ec91aecfceebf47bd4056e1f981664_a03688cf30114b2e8d8aa1c815bcd036(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__17ec91aecfceebf47bd4056e1f981664_a03688cf30114b2e8d8aa1c815bcd036(_17ec91aecfceebf47bd4056e1f981664_a03688cf30114b2e8d8aa1c815bcd036 command)
		{
		}

		private void BakeCommandBinding__17ec91aecfceebf47bd4056e1f981664_b4b89d3564924c1d9adb611ec3210553(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__17ec91aecfceebf47bd4056e1f981664_b4b89d3564924c1d9adb611ec3210553(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__17ec91aecfceebf47bd4056e1f981664_b4b89d3564924c1d9adb611ec3210553(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__17ec91aecfceebf47bd4056e1f981664_b4b89d3564924c1d9adb611ec3210553(_17ec91aecfceebf47bd4056e1f981664_b4b89d3564924c1d9adb611ec3210553 command)
		{
		}

		private void BakeCommandBinding__17ec91aecfceebf47bd4056e1f981664_6eb3b60792c14d79bdf7dc21e5380f09(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__17ec91aecfceebf47bd4056e1f981664_6eb3b60792c14d79bdf7dc21e5380f09(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__17ec91aecfceebf47bd4056e1f981664_6eb3b60792c14d79bdf7dc21e5380f09(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__17ec91aecfceebf47bd4056e1f981664_6eb3b60792c14d79bdf7dc21e5380f09(_17ec91aecfceebf47bd4056e1f981664_6eb3b60792c14d79bdf7dc21e5380f09 command)
		{
		}

		private void BakeCommandBinding__17ec91aecfceebf47bd4056e1f981664_4c1ee87bfbad4085bf9198f1bdf4d8a2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__17ec91aecfceebf47bd4056e1f981664_4c1ee87bfbad4085bf9198f1bdf4d8a2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__17ec91aecfceebf47bd4056e1f981664_4c1ee87bfbad4085bf9198f1bdf4d8a2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__17ec91aecfceebf47bd4056e1f981664_4c1ee87bfbad4085bf9198f1bdf4d8a2(_17ec91aecfceebf47bd4056e1f981664_4c1ee87bfbad4085bf9198f1bdf4d8a2 command)
		{
		}

		private void BakeCommandBinding__17ec91aecfceebf47bd4056e1f981664_f853fabc3d284dc19bb4e858004c7320(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__17ec91aecfceebf47bd4056e1f981664_f853fabc3d284dc19bb4e858004c7320(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__17ec91aecfceebf47bd4056e1f981664_f853fabc3d284dc19bb4e858004c7320(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__17ec91aecfceebf47bd4056e1f981664_f853fabc3d284dc19bb4e858004c7320(_17ec91aecfceebf47bd4056e1f981664_f853fabc3d284dc19bb4e858004c7320 command)
		{
		}

		private void BakeCommandBinding__17ec91aecfceebf47bd4056e1f981664_52637e0eb42d49c298b52b659eae94c1(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__17ec91aecfceebf47bd4056e1f981664_52637e0eb42d49c298b52b659eae94c1(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__17ec91aecfceebf47bd4056e1f981664_52637e0eb42d49c298b52b659eae94c1(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__17ec91aecfceebf47bd4056e1f981664_52637e0eb42d49c298b52b659eae94c1(_17ec91aecfceebf47bd4056e1f981664_52637e0eb42d49c298b52b659eae94c1 command)
		{
		}

		private void BakeCommandBinding__17ec91aecfceebf47bd4056e1f981664_e36a41b6aea64d8db3537b02bfe89cb6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__17ec91aecfceebf47bd4056e1f981664_e36a41b6aea64d8db3537b02bfe89cb6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__17ec91aecfceebf47bd4056e1f981664_e36a41b6aea64d8db3537b02bfe89cb6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__17ec91aecfceebf47bd4056e1f981664_e36a41b6aea64d8db3537b02bfe89cb6(_17ec91aecfceebf47bd4056e1f981664_e36a41b6aea64d8db3537b02bfe89cb6 command)
		{
		}

		private void BakeCommandBinding__17ec91aecfceebf47bd4056e1f981664_a340c600d56c47b0bf07c4298051c0b7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__17ec91aecfceebf47bd4056e1f981664_a340c600d56c47b0bf07c4298051c0b7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__17ec91aecfceebf47bd4056e1f981664_a340c600d56c47b0bf07c4298051c0b7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__17ec91aecfceebf47bd4056e1f981664_a340c600d56c47b0bf07c4298051c0b7(_17ec91aecfceebf47bd4056e1f981664_a340c600d56c47b0bf07c4298051c0b7 command)
		{
		}

		private void BakeCommandBinding__17ec91aecfceebf47bd4056e1f981664_2506270c71484cb69f1cad552bf406e0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__17ec91aecfceebf47bd4056e1f981664_2506270c71484cb69f1cad552bf406e0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__17ec91aecfceebf47bd4056e1f981664_2506270c71484cb69f1cad552bf406e0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__17ec91aecfceebf47bd4056e1f981664_2506270c71484cb69f1cad552bf406e0(_17ec91aecfceebf47bd4056e1f981664_2506270c71484cb69f1cad552bf406e0 command)
		{
		}

		private void BakeCommandBinding__17ec91aecfceebf47bd4056e1f981664_d54de59d26c94d7d8e464898fffa22f0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__17ec91aecfceebf47bd4056e1f981664_d54de59d26c94d7d8e464898fffa22f0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__17ec91aecfceebf47bd4056e1f981664_d54de59d26c94d7d8e464898fffa22f0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__17ec91aecfceebf47bd4056e1f981664_d54de59d26c94d7d8e464898fffa22f0(_17ec91aecfceebf47bd4056e1f981664_d54de59d26c94d7d8e464898fffa22f0 command)
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
