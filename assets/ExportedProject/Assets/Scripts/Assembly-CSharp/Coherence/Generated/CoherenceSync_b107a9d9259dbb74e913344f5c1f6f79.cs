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
	public class CoherenceSync_b107a9d9259dbb74e913344f5c1f6f79 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _b107a9d9259dbb74e913344f5c1f6f79_2d547b5e2dec48bea36f8462950bcd00_CommandTarget;

		private CharacterController _b107a9d9259dbb74e913344f5c1f6f79_544a24bcaff744868fe0db7bda7601f0_CommandTarget;

		private CharacterController _b107a9d9259dbb74e913344f5c1f6f79_223ec1dc2c644780a6bd91218ac20000_CommandTarget;

		private CharacterController _b107a9d9259dbb74e913344f5c1f6f79_6b1d851b300d4e9392dce4c680f37dc2_CommandTarget;

		private CharacterController _b107a9d9259dbb74e913344f5c1f6f79_2b05217fd8a5442b989ead945e2297fc_CommandTarget;

		private CharacterController _b107a9d9259dbb74e913344f5c1f6f79_5682c36a9b2e4bb38f0d389c9c1b2f2b_CommandTarget;

		private CharacterController _b107a9d9259dbb74e913344f5c1f6f79_9ee9ff4e2a3a49508a333cfb1281cbdd_CommandTarget;

		private CharacterController _b107a9d9259dbb74e913344f5c1f6f79_e9fdbb6755e742e69bbfc3f80304c737_CommandTarget;

		private CharacterController _b107a9d9259dbb74e913344f5c1f6f79_59d7a08c456e4529a1e8034c9bb74186_CommandTarget;

		private CharacterController _b107a9d9259dbb74e913344f5c1f6f79_5fcc7fab67284a5486a68700c0db6c1d_CommandTarget;

		private CharacterController _b107a9d9259dbb74e913344f5c1f6f79_164edf9fe90f40958a802ffc8324bcef_CommandTarget;

		private CharacterController _b107a9d9259dbb74e913344f5c1f6f79_41e963bcddf54a578cd632ec50958235_CommandTarget;

		private CharacterController _b107a9d9259dbb74e913344f5c1f6f79_22b0425b49834e258c1d214d9ca49f9f_CommandTarget;

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

		private void BakeCommandBinding__b107a9d9259dbb74e913344f5c1f6f79_2d547b5e2dec48bea36f8462950bcd00(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b107a9d9259dbb74e913344f5c1f6f79_2d547b5e2dec48bea36f8462950bcd00(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b107a9d9259dbb74e913344f5c1f6f79_2d547b5e2dec48bea36f8462950bcd00(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b107a9d9259dbb74e913344f5c1f6f79_2d547b5e2dec48bea36f8462950bcd00(_b107a9d9259dbb74e913344f5c1f6f79_2d547b5e2dec48bea36f8462950bcd00 command)
		{
		}

		private void BakeCommandBinding__b107a9d9259dbb74e913344f5c1f6f79_544a24bcaff744868fe0db7bda7601f0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b107a9d9259dbb74e913344f5c1f6f79_544a24bcaff744868fe0db7bda7601f0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b107a9d9259dbb74e913344f5c1f6f79_544a24bcaff744868fe0db7bda7601f0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b107a9d9259dbb74e913344f5c1f6f79_544a24bcaff744868fe0db7bda7601f0(_b107a9d9259dbb74e913344f5c1f6f79_544a24bcaff744868fe0db7bda7601f0 command)
		{
		}

		private void BakeCommandBinding__b107a9d9259dbb74e913344f5c1f6f79_223ec1dc2c644780a6bd91218ac20000(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b107a9d9259dbb74e913344f5c1f6f79_223ec1dc2c644780a6bd91218ac20000(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b107a9d9259dbb74e913344f5c1f6f79_223ec1dc2c644780a6bd91218ac20000(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b107a9d9259dbb74e913344f5c1f6f79_223ec1dc2c644780a6bd91218ac20000(_b107a9d9259dbb74e913344f5c1f6f79_223ec1dc2c644780a6bd91218ac20000 command)
		{
		}

		private void BakeCommandBinding__b107a9d9259dbb74e913344f5c1f6f79_6b1d851b300d4e9392dce4c680f37dc2(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b107a9d9259dbb74e913344f5c1f6f79_6b1d851b300d4e9392dce4c680f37dc2(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b107a9d9259dbb74e913344f5c1f6f79_6b1d851b300d4e9392dce4c680f37dc2(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b107a9d9259dbb74e913344f5c1f6f79_6b1d851b300d4e9392dce4c680f37dc2(_b107a9d9259dbb74e913344f5c1f6f79_6b1d851b300d4e9392dce4c680f37dc2 command)
		{
		}

		private void BakeCommandBinding__b107a9d9259dbb74e913344f5c1f6f79_2b05217fd8a5442b989ead945e2297fc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b107a9d9259dbb74e913344f5c1f6f79_2b05217fd8a5442b989ead945e2297fc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b107a9d9259dbb74e913344f5c1f6f79_2b05217fd8a5442b989ead945e2297fc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b107a9d9259dbb74e913344f5c1f6f79_2b05217fd8a5442b989ead945e2297fc(_b107a9d9259dbb74e913344f5c1f6f79_2b05217fd8a5442b989ead945e2297fc command)
		{
		}

		private void BakeCommandBinding__b107a9d9259dbb74e913344f5c1f6f79_5682c36a9b2e4bb38f0d389c9c1b2f2b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b107a9d9259dbb74e913344f5c1f6f79_5682c36a9b2e4bb38f0d389c9c1b2f2b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b107a9d9259dbb74e913344f5c1f6f79_5682c36a9b2e4bb38f0d389c9c1b2f2b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b107a9d9259dbb74e913344f5c1f6f79_5682c36a9b2e4bb38f0d389c9c1b2f2b(_b107a9d9259dbb74e913344f5c1f6f79_5682c36a9b2e4bb38f0d389c9c1b2f2b command)
		{
		}

		private void BakeCommandBinding__b107a9d9259dbb74e913344f5c1f6f79_9ee9ff4e2a3a49508a333cfb1281cbdd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b107a9d9259dbb74e913344f5c1f6f79_9ee9ff4e2a3a49508a333cfb1281cbdd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b107a9d9259dbb74e913344f5c1f6f79_9ee9ff4e2a3a49508a333cfb1281cbdd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b107a9d9259dbb74e913344f5c1f6f79_9ee9ff4e2a3a49508a333cfb1281cbdd(_b107a9d9259dbb74e913344f5c1f6f79_9ee9ff4e2a3a49508a333cfb1281cbdd command)
		{
		}

		private void BakeCommandBinding__b107a9d9259dbb74e913344f5c1f6f79_e9fdbb6755e742e69bbfc3f80304c737(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b107a9d9259dbb74e913344f5c1f6f79_e9fdbb6755e742e69bbfc3f80304c737(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b107a9d9259dbb74e913344f5c1f6f79_e9fdbb6755e742e69bbfc3f80304c737(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b107a9d9259dbb74e913344f5c1f6f79_e9fdbb6755e742e69bbfc3f80304c737(_b107a9d9259dbb74e913344f5c1f6f79_e9fdbb6755e742e69bbfc3f80304c737 command)
		{
		}

		private void BakeCommandBinding__b107a9d9259dbb74e913344f5c1f6f79_59d7a08c456e4529a1e8034c9bb74186(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b107a9d9259dbb74e913344f5c1f6f79_59d7a08c456e4529a1e8034c9bb74186(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b107a9d9259dbb74e913344f5c1f6f79_59d7a08c456e4529a1e8034c9bb74186(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b107a9d9259dbb74e913344f5c1f6f79_59d7a08c456e4529a1e8034c9bb74186(_b107a9d9259dbb74e913344f5c1f6f79_59d7a08c456e4529a1e8034c9bb74186 command)
		{
		}

		private void BakeCommandBinding__b107a9d9259dbb74e913344f5c1f6f79_5fcc7fab67284a5486a68700c0db6c1d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b107a9d9259dbb74e913344f5c1f6f79_5fcc7fab67284a5486a68700c0db6c1d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b107a9d9259dbb74e913344f5c1f6f79_5fcc7fab67284a5486a68700c0db6c1d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b107a9d9259dbb74e913344f5c1f6f79_5fcc7fab67284a5486a68700c0db6c1d(_b107a9d9259dbb74e913344f5c1f6f79_5fcc7fab67284a5486a68700c0db6c1d command)
		{
		}

		private void BakeCommandBinding__b107a9d9259dbb74e913344f5c1f6f79_164edf9fe90f40958a802ffc8324bcef(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b107a9d9259dbb74e913344f5c1f6f79_164edf9fe90f40958a802ffc8324bcef(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b107a9d9259dbb74e913344f5c1f6f79_164edf9fe90f40958a802ffc8324bcef(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b107a9d9259dbb74e913344f5c1f6f79_164edf9fe90f40958a802ffc8324bcef(_b107a9d9259dbb74e913344f5c1f6f79_164edf9fe90f40958a802ffc8324bcef command)
		{
		}

		private void BakeCommandBinding__b107a9d9259dbb74e913344f5c1f6f79_41e963bcddf54a578cd632ec50958235(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b107a9d9259dbb74e913344f5c1f6f79_41e963bcddf54a578cd632ec50958235(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b107a9d9259dbb74e913344f5c1f6f79_41e963bcddf54a578cd632ec50958235(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b107a9d9259dbb74e913344f5c1f6f79_41e963bcddf54a578cd632ec50958235(_b107a9d9259dbb74e913344f5c1f6f79_41e963bcddf54a578cd632ec50958235 command)
		{
		}

		private void BakeCommandBinding__b107a9d9259dbb74e913344f5c1f6f79_22b0425b49834e258c1d214d9ca49f9f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__b107a9d9259dbb74e913344f5c1f6f79_22b0425b49834e258c1d214d9ca49f9f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__b107a9d9259dbb74e913344f5c1f6f79_22b0425b49834e258c1d214d9ca49f9f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__b107a9d9259dbb74e913344f5c1f6f79_22b0425b49834e258c1d214d9ca49f9f(_b107a9d9259dbb74e913344f5c1f6f79_22b0425b49834e258c1d214d9ca49f9f command)
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
