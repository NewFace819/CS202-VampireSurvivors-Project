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
	public class CoherenceSync_020faf22b8e701447823f5b4d632326c : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _020faf22b8e701447823f5b4d632326c_ba404c53feca4213b29b32bcc5359edc_CommandTarget;

		private CharacterController _020faf22b8e701447823f5b4d632326c_47b1909b202749a885bb2f6f19128c28_CommandTarget;

		private CharacterController _020faf22b8e701447823f5b4d632326c_4d83b9f7915f4ce497a3f83feda5b212_CommandTarget;

		private CharacterController _020faf22b8e701447823f5b4d632326c_975e0302792f42c3b940f65c2c4fe11a_CommandTarget;

		private CharacterController _020faf22b8e701447823f5b4d632326c_c9a39ef5cccd4342925eba643bca17b9_CommandTarget;

		private CharacterController _020faf22b8e701447823f5b4d632326c_78e60a5c6ac247029e3a1df86485de08_CommandTarget;

		private CharacterController _020faf22b8e701447823f5b4d632326c_cbde667d037446a5a142e65b39ac3f84_CommandTarget;

		private CharacterController _020faf22b8e701447823f5b4d632326c_43c061b1c12b4ffcb4641d02c2412518_CommandTarget;

		private CharacterController _020faf22b8e701447823f5b4d632326c_c69a218078364b1ba7af5a790cc0132f_CommandTarget;

		private CharacterController _020faf22b8e701447823f5b4d632326c_1fb88c836e5c4221ad30db4236fb7b21_CommandTarget;

		private CharacterController _020faf22b8e701447823f5b4d632326c_60a42e0228c74edc80a83c78cfb242f4_CommandTarget;

		private CharacterController _020faf22b8e701447823f5b4d632326c_9b936e46caae40738c30a45886f64055_CommandTarget;

		private CharacterController _020faf22b8e701447823f5b4d632326c_29f5a5daea204573b75827480b1437bf_CommandTarget;

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

		private void BakeCommandBinding__020faf22b8e701447823f5b4d632326c_ba404c53feca4213b29b32bcc5359edc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__020faf22b8e701447823f5b4d632326c_ba404c53feca4213b29b32bcc5359edc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__020faf22b8e701447823f5b4d632326c_ba404c53feca4213b29b32bcc5359edc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__020faf22b8e701447823f5b4d632326c_ba404c53feca4213b29b32bcc5359edc(_020faf22b8e701447823f5b4d632326c_ba404c53feca4213b29b32bcc5359edc command)
		{
		}

		private void BakeCommandBinding__020faf22b8e701447823f5b4d632326c_47b1909b202749a885bb2f6f19128c28(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__020faf22b8e701447823f5b4d632326c_47b1909b202749a885bb2f6f19128c28(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__020faf22b8e701447823f5b4d632326c_47b1909b202749a885bb2f6f19128c28(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__020faf22b8e701447823f5b4d632326c_47b1909b202749a885bb2f6f19128c28(_020faf22b8e701447823f5b4d632326c_47b1909b202749a885bb2f6f19128c28 command)
		{
		}

		private void BakeCommandBinding__020faf22b8e701447823f5b4d632326c_4d83b9f7915f4ce497a3f83feda5b212(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__020faf22b8e701447823f5b4d632326c_4d83b9f7915f4ce497a3f83feda5b212(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__020faf22b8e701447823f5b4d632326c_4d83b9f7915f4ce497a3f83feda5b212(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__020faf22b8e701447823f5b4d632326c_4d83b9f7915f4ce497a3f83feda5b212(_020faf22b8e701447823f5b4d632326c_4d83b9f7915f4ce497a3f83feda5b212 command)
		{
		}

		private void BakeCommandBinding__020faf22b8e701447823f5b4d632326c_975e0302792f42c3b940f65c2c4fe11a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__020faf22b8e701447823f5b4d632326c_975e0302792f42c3b940f65c2c4fe11a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__020faf22b8e701447823f5b4d632326c_975e0302792f42c3b940f65c2c4fe11a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__020faf22b8e701447823f5b4d632326c_975e0302792f42c3b940f65c2c4fe11a(_020faf22b8e701447823f5b4d632326c_975e0302792f42c3b940f65c2c4fe11a command)
		{
		}

		private void BakeCommandBinding__020faf22b8e701447823f5b4d632326c_c9a39ef5cccd4342925eba643bca17b9(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__020faf22b8e701447823f5b4d632326c_c9a39ef5cccd4342925eba643bca17b9(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__020faf22b8e701447823f5b4d632326c_c9a39ef5cccd4342925eba643bca17b9(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__020faf22b8e701447823f5b4d632326c_c9a39ef5cccd4342925eba643bca17b9(_020faf22b8e701447823f5b4d632326c_c9a39ef5cccd4342925eba643bca17b9 command)
		{
		}

		private void BakeCommandBinding__020faf22b8e701447823f5b4d632326c_78e60a5c6ac247029e3a1df86485de08(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__020faf22b8e701447823f5b4d632326c_78e60a5c6ac247029e3a1df86485de08(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__020faf22b8e701447823f5b4d632326c_78e60a5c6ac247029e3a1df86485de08(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__020faf22b8e701447823f5b4d632326c_78e60a5c6ac247029e3a1df86485de08(_020faf22b8e701447823f5b4d632326c_78e60a5c6ac247029e3a1df86485de08 command)
		{
		}

		private void BakeCommandBinding__020faf22b8e701447823f5b4d632326c_cbde667d037446a5a142e65b39ac3f84(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__020faf22b8e701447823f5b4d632326c_cbde667d037446a5a142e65b39ac3f84(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__020faf22b8e701447823f5b4d632326c_cbde667d037446a5a142e65b39ac3f84(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__020faf22b8e701447823f5b4d632326c_cbde667d037446a5a142e65b39ac3f84(_020faf22b8e701447823f5b4d632326c_cbde667d037446a5a142e65b39ac3f84 command)
		{
		}

		private void BakeCommandBinding__020faf22b8e701447823f5b4d632326c_43c061b1c12b4ffcb4641d02c2412518(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__020faf22b8e701447823f5b4d632326c_43c061b1c12b4ffcb4641d02c2412518(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__020faf22b8e701447823f5b4d632326c_43c061b1c12b4ffcb4641d02c2412518(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__020faf22b8e701447823f5b4d632326c_43c061b1c12b4ffcb4641d02c2412518(_020faf22b8e701447823f5b4d632326c_43c061b1c12b4ffcb4641d02c2412518 command)
		{
		}

		private void BakeCommandBinding__020faf22b8e701447823f5b4d632326c_c69a218078364b1ba7af5a790cc0132f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__020faf22b8e701447823f5b4d632326c_c69a218078364b1ba7af5a790cc0132f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__020faf22b8e701447823f5b4d632326c_c69a218078364b1ba7af5a790cc0132f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__020faf22b8e701447823f5b4d632326c_c69a218078364b1ba7af5a790cc0132f(_020faf22b8e701447823f5b4d632326c_c69a218078364b1ba7af5a790cc0132f command)
		{
		}

		private void BakeCommandBinding__020faf22b8e701447823f5b4d632326c_1fb88c836e5c4221ad30db4236fb7b21(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__020faf22b8e701447823f5b4d632326c_1fb88c836e5c4221ad30db4236fb7b21(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__020faf22b8e701447823f5b4d632326c_1fb88c836e5c4221ad30db4236fb7b21(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__020faf22b8e701447823f5b4d632326c_1fb88c836e5c4221ad30db4236fb7b21(_020faf22b8e701447823f5b4d632326c_1fb88c836e5c4221ad30db4236fb7b21 command)
		{
		}

		private void BakeCommandBinding__020faf22b8e701447823f5b4d632326c_60a42e0228c74edc80a83c78cfb242f4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__020faf22b8e701447823f5b4d632326c_60a42e0228c74edc80a83c78cfb242f4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__020faf22b8e701447823f5b4d632326c_60a42e0228c74edc80a83c78cfb242f4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__020faf22b8e701447823f5b4d632326c_60a42e0228c74edc80a83c78cfb242f4(_020faf22b8e701447823f5b4d632326c_60a42e0228c74edc80a83c78cfb242f4 command)
		{
		}

		private void BakeCommandBinding__020faf22b8e701447823f5b4d632326c_9b936e46caae40738c30a45886f64055(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__020faf22b8e701447823f5b4d632326c_9b936e46caae40738c30a45886f64055(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__020faf22b8e701447823f5b4d632326c_9b936e46caae40738c30a45886f64055(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__020faf22b8e701447823f5b4d632326c_9b936e46caae40738c30a45886f64055(_020faf22b8e701447823f5b4d632326c_9b936e46caae40738c30a45886f64055 command)
		{
		}

		private void BakeCommandBinding__020faf22b8e701447823f5b4d632326c_29f5a5daea204573b75827480b1437bf(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__020faf22b8e701447823f5b4d632326c_29f5a5daea204573b75827480b1437bf(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__020faf22b8e701447823f5b4d632326c_29f5a5daea204573b75827480b1437bf(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__020faf22b8e701447823f5b4d632326c_29f5a5daea204573b75827480b1437bf(_020faf22b8e701447823f5b4d632326c_29f5a5daea204573b75827480b1437bf command)
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
