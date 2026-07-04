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
	public class CoherenceSync_ae94a6849deb3d14aa3b493baa74a4e4 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _ae94a6849deb3d14aa3b493baa74a4e4_27e0562af0644a7692aa27852ee4b9ba_CommandTarget;

		private CharacterController _ae94a6849deb3d14aa3b493baa74a4e4_bee46ccd9f484da686428869b9144850_CommandTarget;

		private CharacterController _ae94a6849deb3d14aa3b493baa74a4e4_5cb98712251a482a91389eff4ce8a9a5_CommandTarget;

		private CharacterController _ae94a6849deb3d14aa3b493baa74a4e4_e920ad85fc794d9796115884a1bf4b56_CommandTarget;

		private CharacterController _ae94a6849deb3d14aa3b493baa74a4e4_9306725b2bd24ec19659f9ba00c092b6_CommandTarget;

		private CharacterController _ae94a6849deb3d14aa3b493baa74a4e4_554be781dbeb470da75ce670538c6a87_CommandTarget;

		private CharacterController _ae94a6849deb3d14aa3b493baa74a4e4_9435341580a24958bbfa5c945fdf8870_CommandTarget;

		private CharacterController _ae94a6849deb3d14aa3b493baa74a4e4_1f891dd690c546868fe2e974b1b1e954_CommandTarget;

		private CharacterController _ae94a6849deb3d14aa3b493baa74a4e4_d3bc30971a8941c7947845d657d59204_CommandTarget;

		private CharacterController _ae94a6849deb3d14aa3b493baa74a4e4_ac1d607d4c524a2cbcd0cf0ce9f67a9e_CommandTarget;

		private CharacterController _ae94a6849deb3d14aa3b493baa74a4e4_ddea118575e84492b0aa9f9a9ee58043_CommandTarget;

		private CharacterController _ae94a6849deb3d14aa3b493baa74a4e4_ec494500245d42a097bba442cf3c2c48_CommandTarget;

		private CharacterController _ae94a6849deb3d14aa3b493baa74a4e4_a8dc7177b75b4a1abbb6ca8c7e2a448c_CommandTarget;

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

		private void BakeCommandBinding__ae94a6849deb3d14aa3b493baa74a4e4_27e0562af0644a7692aa27852ee4b9ba(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ae94a6849deb3d14aa3b493baa74a4e4_27e0562af0644a7692aa27852ee4b9ba(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ae94a6849deb3d14aa3b493baa74a4e4_27e0562af0644a7692aa27852ee4b9ba(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ae94a6849deb3d14aa3b493baa74a4e4_27e0562af0644a7692aa27852ee4b9ba(_ae94a6849deb3d14aa3b493baa74a4e4_27e0562af0644a7692aa27852ee4b9ba command)
		{
		}

		private void BakeCommandBinding__ae94a6849deb3d14aa3b493baa74a4e4_bee46ccd9f484da686428869b9144850(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ae94a6849deb3d14aa3b493baa74a4e4_bee46ccd9f484da686428869b9144850(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ae94a6849deb3d14aa3b493baa74a4e4_bee46ccd9f484da686428869b9144850(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ae94a6849deb3d14aa3b493baa74a4e4_bee46ccd9f484da686428869b9144850(_ae94a6849deb3d14aa3b493baa74a4e4_bee46ccd9f484da686428869b9144850 command)
		{
		}

		private void BakeCommandBinding__ae94a6849deb3d14aa3b493baa74a4e4_5cb98712251a482a91389eff4ce8a9a5(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ae94a6849deb3d14aa3b493baa74a4e4_5cb98712251a482a91389eff4ce8a9a5(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ae94a6849deb3d14aa3b493baa74a4e4_5cb98712251a482a91389eff4ce8a9a5(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ae94a6849deb3d14aa3b493baa74a4e4_5cb98712251a482a91389eff4ce8a9a5(_ae94a6849deb3d14aa3b493baa74a4e4_5cb98712251a482a91389eff4ce8a9a5 command)
		{
		}

		private void BakeCommandBinding__ae94a6849deb3d14aa3b493baa74a4e4_e920ad85fc794d9796115884a1bf4b56(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ae94a6849deb3d14aa3b493baa74a4e4_e920ad85fc794d9796115884a1bf4b56(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ae94a6849deb3d14aa3b493baa74a4e4_e920ad85fc794d9796115884a1bf4b56(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ae94a6849deb3d14aa3b493baa74a4e4_e920ad85fc794d9796115884a1bf4b56(_ae94a6849deb3d14aa3b493baa74a4e4_e920ad85fc794d9796115884a1bf4b56 command)
		{
		}

		private void BakeCommandBinding__ae94a6849deb3d14aa3b493baa74a4e4_9306725b2bd24ec19659f9ba00c092b6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ae94a6849deb3d14aa3b493baa74a4e4_9306725b2bd24ec19659f9ba00c092b6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ae94a6849deb3d14aa3b493baa74a4e4_9306725b2bd24ec19659f9ba00c092b6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ae94a6849deb3d14aa3b493baa74a4e4_9306725b2bd24ec19659f9ba00c092b6(_ae94a6849deb3d14aa3b493baa74a4e4_9306725b2bd24ec19659f9ba00c092b6 command)
		{
		}

		private void BakeCommandBinding__ae94a6849deb3d14aa3b493baa74a4e4_554be781dbeb470da75ce670538c6a87(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ae94a6849deb3d14aa3b493baa74a4e4_554be781dbeb470da75ce670538c6a87(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ae94a6849deb3d14aa3b493baa74a4e4_554be781dbeb470da75ce670538c6a87(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ae94a6849deb3d14aa3b493baa74a4e4_554be781dbeb470da75ce670538c6a87(_ae94a6849deb3d14aa3b493baa74a4e4_554be781dbeb470da75ce670538c6a87 command)
		{
		}

		private void BakeCommandBinding__ae94a6849deb3d14aa3b493baa74a4e4_9435341580a24958bbfa5c945fdf8870(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ae94a6849deb3d14aa3b493baa74a4e4_9435341580a24958bbfa5c945fdf8870(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ae94a6849deb3d14aa3b493baa74a4e4_9435341580a24958bbfa5c945fdf8870(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ae94a6849deb3d14aa3b493baa74a4e4_9435341580a24958bbfa5c945fdf8870(_ae94a6849deb3d14aa3b493baa74a4e4_9435341580a24958bbfa5c945fdf8870 command)
		{
		}

		private void BakeCommandBinding__ae94a6849deb3d14aa3b493baa74a4e4_1f891dd690c546868fe2e974b1b1e954(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ae94a6849deb3d14aa3b493baa74a4e4_1f891dd690c546868fe2e974b1b1e954(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ae94a6849deb3d14aa3b493baa74a4e4_1f891dd690c546868fe2e974b1b1e954(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ae94a6849deb3d14aa3b493baa74a4e4_1f891dd690c546868fe2e974b1b1e954(_ae94a6849deb3d14aa3b493baa74a4e4_1f891dd690c546868fe2e974b1b1e954 command)
		{
		}

		private void BakeCommandBinding__ae94a6849deb3d14aa3b493baa74a4e4_d3bc30971a8941c7947845d657d59204(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ae94a6849deb3d14aa3b493baa74a4e4_d3bc30971a8941c7947845d657d59204(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ae94a6849deb3d14aa3b493baa74a4e4_d3bc30971a8941c7947845d657d59204(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ae94a6849deb3d14aa3b493baa74a4e4_d3bc30971a8941c7947845d657d59204(_ae94a6849deb3d14aa3b493baa74a4e4_d3bc30971a8941c7947845d657d59204 command)
		{
		}

		private void BakeCommandBinding__ae94a6849deb3d14aa3b493baa74a4e4_ac1d607d4c524a2cbcd0cf0ce9f67a9e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ae94a6849deb3d14aa3b493baa74a4e4_ac1d607d4c524a2cbcd0cf0ce9f67a9e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ae94a6849deb3d14aa3b493baa74a4e4_ac1d607d4c524a2cbcd0cf0ce9f67a9e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ae94a6849deb3d14aa3b493baa74a4e4_ac1d607d4c524a2cbcd0cf0ce9f67a9e(_ae94a6849deb3d14aa3b493baa74a4e4_ac1d607d4c524a2cbcd0cf0ce9f67a9e command)
		{
		}

		private void BakeCommandBinding__ae94a6849deb3d14aa3b493baa74a4e4_ddea118575e84492b0aa9f9a9ee58043(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ae94a6849deb3d14aa3b493baa74a4e4_ddea118575e84492b0aa9f9a9ee58043(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ae94a6849deb3d14aa3b493baa74a4e4_ddea118575e84492b0aa9f9a9ee58043(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ae94a6849deb3d14aa3b493baa74a4e4_ddea118575e84492b0aa9f9a9ee58043(_ae94a6849deb3d14aa3b493baa74a4e4_ddea118575e84492b0aa9f9a9ee58043 command)
		{
		}

		private void BakeCommandBinding__ae94a6849deb3d14aa3b493baa74a4e4_ec494500245d42a097bba442cf3c2c48(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ae94a6849deb3d14aa3b493baa74a4e4_ec494500245d42a097bba442cf3c2c48(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ae94a6849deb3d14aa3b493baa74a4e4_ec494500245d42a097bba442cf3c2c48(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ae94a6849deb3d14aa3b493baa74a4e4_ec494500245d42a097bba442cf3c2c48(_ae94a6849deb3d14aa3b493baa74a4e4_ec494500245d42a097bba442cf3c2c48 command)
		{
		}

		private void BakeCommandBinding__ae94a6849deb3d14aa3b493baa74a4e4_a8dc7177b75b4a1abbb6ca8c7e2a448c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__ae94a6849deb3d14aa3b493baa74a4e4_a8dc7177b75b4a1abbb6ca8c7e2a448c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__ae94a6849deb3d14aa3b493baa74a4e4_a8dc7177b75b4a1abbb6ca8c7e2a448c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__ae94a6849deb3d14aa3b493baa74a4e4_a8dc7177b75b4a1abbb6ca8c7e2a448c(_ae94a6849deb3d14aa3b493baa74a4e4_a8dc7177b75b4a1abbb6ca8c7e2a448c command)
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
