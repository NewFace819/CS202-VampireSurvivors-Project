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
	public class CoherenceSync_42a11538319fb0e45949bd1db0d231e3 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _42a11538319fb0e45949bd1db0d231e3_c229b3292cae451286489c11e1dea409_CommandTarget;

		private CharacterController _42a11538319fb0e45949bd1db0d231e3_4e4a3843dfa844a2bf08e3ff1b22cba6_CommandTarget;

		private CharacterController _42a11538319fb0e45949bd1db0d231e3_6287ade074574ffe9b375b0610dcfa03_CommandTarget;

		private CharacterController _42a11538319fb0e45949bd1db0d231e3_ecd81e3eec034b8ab70ea15130a30032_CommandTarget;

		private CharacterController _42a11538319fb0e45949bd1db0d231e3_2060eb7b4a87471eb15c174cd22c0263_CommandTarget;

		private CharacterController _42a11538319fb0e45949bd1db0d231e3_aecab7fc8e0640b99e7d483c152ca624_CommandTarget;

		private CharacterController _42a11538319fb0e45949bd1db0d231e3_0242f28558dd410a83c116d7b092ee57_CommandTarget;

		private CharacterController _42a11538319fb0e45949bd1db0d231e3_24cf5c5aa7744fba866e4bf74ba790e7_CommandTarget;

		private CharacterController _42a11538319fb0e45949bd1db0d231e3_1eb7db22197d48b0862e4b5eadb82e88_CommandTarget;

		private CharacterController _42a11538319fb0e45949bd1db0d231e3_482c9329a98e4f62aae75a291d54cc4d_CommandTarget;

		private CharacterController _42a11538319fb0e45949bd1db0d231e3_a827fed36a9d424aac9aed9e08f2504a_CommandTarget;

		private CharacterController _42a11538319fb0e45949bd1db0d231e3_f9610b84529f4a29b26a0ef378224484_CommandTarget;

		private CharacterController _42a11538319fb0e45949bd1db0d231e3_354e0162035a46869a991697736cabe0_CommandTarget;

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

		private void BakeCommandBinding__42a11538319fb0e45949bd1db0d231e3_c229b3292cae451286489c11e1dea409(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42a11538319fb0e45949bd1db0d231e3_c229b3292cae451286489c11e1dea409(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42a11538319fb0e45949bd1db0d231e3_c229b3292cae451286489c11e1dea409(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42a11538319fb0e45949bd1db0d231e3_c229b3292cae451286489c11e1dea409(_42a11538319fb0e45949bd1db0d231e3_c229b3292cae451286489c11e1dea409 command)
		{
		}

		private void BakeCommandBinding__42a11538319fb0e45949bd1db0d231e3_4e4a3843dfa844a2bf08e3ff1b22cba6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42a11538319fb0e45949bd1db0d231e3_4e4a3843dfa844a2bf08e3ff1b22cba6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42a11538319fb0e45949bd1db0d231e3_4e4a3843dfa844a2bf08e3ff1b22cba6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42a11538319fb0e45949bd1db0d231e3_4e4a3843dfa844a2bf08e3ff1b22cba6(_42a11538319fb0e45949bd1db0d231e3_4e4a3843dfa844a2bf08e3ff1b22cba6 command)
		{
		}

		private void BakeCommandBinding__42a11538319fb0e45949bd1db0d231e3_6287ade074574ffe9b375b0610dcfa03(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42a11538319fb0e45949bd1db0d231e3_6287ade074574ffe9b375b0610dcfa03(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42a11538319fb0e45949bd1db0d231e3_6287ade074574ffe9b375b0610dcfa03(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42a11538319fb0e45949bd1db0d231e3_6287ade074574ffe9b375b0610dcfa03(_42a11538319fb0e45949bd1db0d231e3_6287ade074574ffe9b375b0610dcfa03 command)
		{
		}

		private void BakeCommandBinding__42a11538319fb0e45949bd1db0d231e3_ecd81e3eec034b8ab70ea15130a30032(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42a11538319fb0e45949bd1db0d231e3_ecd81e3eec034b8ab70ea15130a30032(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42a11538319fb0e45949bd1db0d231e3_ecd81e3eec034b8ab70ea15130a30032(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42a11538319fb0e45949bd1db0d231e3_ecd81e3eec034b8ab70ea15130a30032(_42a11538319fb0e45949bd1db0d231e3_ecd81e3eec034b8ab70ea15130a30032 command)
		{
		}

		private void BakeCommandBinding__42a11538319fb0e45949bd1db0d231e3_2060eb7b4a87471eb15c174cd22c0263(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42a11538319fb0e45949bd1db0d231e3_2060eb7b4a87471eb15c174cd22c0263(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42a11538319fb0e45949bd1db0d231e3_2060eb7b4a87471eb15c174cd22c0263(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42a11538319fb0e45949bd1db0d231e3_2060eb7b4a87471eb15c174cd22c0263(_42a11538319fb0e45949bd1db0d231e3_2060eb7b4a87471eb15c174cd22c0263 command)
		{
		}

		private void BakeCommandBinding__42a11538319fb0e45949bd1db0d231e3_aecab7fc8e0640b99e7d483c152ca624(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42a11538319fb0e45949bd1db0d231e3_aecab7fc8e0640b99e7d483c152ca624(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42a11538319fb0e45949bd1db0d231e3_aecab7fc8e0640b99e7d483c152ca624(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42a11538319fb0e45949bd1db0d231e3_aecab7fc8e0640b99e7d483c152ca624(_42a11538319fb0e45949bd1db0d231e3_aecab7fc8e0640b99e7d483c152ca624 command)
		{
		}

		private void BakeCommandBinding__42a11538319fb0e45949bd1db0d231e3_0242f28558dd410a83c116d7b092ee57(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42a11538319fb0e45949bd1db0d231e3_0242f28558dd410a83c116d7b092ee57(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42a11538319fb0e45949bd1db0d231e3_0242f28558dd410a83c116d7b092ee57(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42a11538319fb0e45949bd1db0d231e3_0242f28558dd410a83c116d7b092ee57(_42a11538319fb0e45949bd1db0d231e3_0242f28558dd410a83c116d7b092ee57 command)
		{
		}

		private void BakeCommandBinding__42a11538319fb0e45949bd1db0d231e3_24cf5c5aa7744fba866e4bf74ba790e7(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42a11538319fb0e45949bd1db0d231e3_24cf5c5aa7744fba866e4bf74ba790e7(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42a11538319fb0e45949bd1db0d231e3_24cf5c5aa7744fba866e4bf74ba790e7(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42a11538319fb0e45949bd1db0d231e3_24cf5c5aa7744fba866e4bf74ba790e7(_42a11538319fb0e45949bd1db0d231e3_24cf5c5aa7744fba866e4bf74ba790e7 command)
		{
		}

		private void BakeCommandBinding__42a11538319fb0e45949bd1db0d231e3_1eb7db22197d48b0862e4b5eadb82e88(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42a11538319fb0e45949bd1db0d231e3_1eb7db22197d48b0862e4b5eadb82e88(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42a11538319fb0e45949bd1db0d231e3_1eb7db22197d48b0862e4b5eadb82e88(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42a11538319fb0e45949bd1db0d231e3_1eb7db22197d48b0862e4b5eadb82e88(_42a11538319fb0e45949bd1db0d231e3_1eb7db22197d48b0862e4b5eadb82e88 command)
		{
		}

		private void BakeCommandBinding__42a11538319fb0e45949bd1db0d231e3_482c9329a98e4f62aae75a291d54cc4d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42a11538319fb0e45949bd1db0d231e3_482c9329a98e4f62aae75a291d54cc4d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42a11538319fb0e45949bd1db0d231e3_482c9329a98e4f62aae75a291d54cc4d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42a11538319fb0e45949bd1db0d231e3_482c9329a98e4f62aae75a291d54cc4d(_42a11538319fb0e45949bd1db0d231e3_482c9329a98e4f62aae75a291d54cc4d command)
		{
		}

		private void BakeCommandBinding__42a11538319fb0e45949bd1db0d231e3_a827fed36a9d424aac9aed9e08f2504a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42a11538319fb0e45949bd1db0d231e3_a827fed36a9d424aac9aed9e08f2504a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42a11538319fb0e45949bd1db0d231e3_a827fed36a9d424aac9aed9e08f2504a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42a11538319fb0e45949bd1db0d231e3_a827fed36a9d424aac9aed9e08f2504a(_42a11538319fb0e45949bd1db0d231e3_a827fed36a9d424aac9aed9e08f2504a command)
		{
		}

		private void BakeCommandBinding__42a11538319fb0e45949bd1db0d231e3_f9610b84529f4a29b26a0ef378224484(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42a11538319fb0e45949bd1db0d231e3_f9610b84529f4a29b26a0ef378224484(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42a11538319fb0e45949bd1db0d231e3_f9610b84529f4a29b26a0ef378224484(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42a11538319fb0e45949bd1db0d231e3_f9610b84529f4a29b26a0ef378224484(_42a11538319fb0e45949bd1db0d231e3_f9610b84529f4a29b26a0ef378224484 command)
		{
		}

		private void BakeCommandBinding__42a11538319fb0e45949bd1db0d231e3_354e0162035a46869a991697736cabe0(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__42a11538319fb0e45949bd1db0d231e3_354e0162035a46869a991697736cabe0(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__42a11538319fb0e45949bd1db0d231e3_354e0162035a46869a991697736cabe0(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__42a11538319fb0e45949bd1db0d231e3_354e0162035a46869a991697736cabe0(_42a11538319fb0e45949bd1db0d231e3_354e0162035a46869a991697736cabe0 command)
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
