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
	public class CoherenceSync_d6fc9483b3f1f6541b4122c5b5318fff : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _d6fc9483b3f1f6541b4122c5b5318fff_d9c329012b3245c1a3daab814ac54873_CommandTarget;

		private CharacterController _d6fc9483b3f1f6541b4122c5b5318fff_5f50c9e2266246cda5a1bc911b9b8fd4_CommandTarget;

		private CharacterController _d6fc9483b3f1f6541b4122c5b5318fff_f530f0470adc4fb38c1af5e153282d78_CommandTarget;

		private CharacterController _d6fc9483b3f1f6541b4122c5b5318fff_795a332d2c2e4a2b9eecb5c58e78be65_CommandTarget;

		private CharacterController _d6fc9483b3f1f6541b4122c5b5318fff_73fe988920f742f882fafc17a2a5c34b_CommandTarget;

		private CharacterController _d6fc9483b3f1f6541b4122c5b5318fff_d69099979d2c48b196a9da6a4e1c756c_CommandTarget;

		private CharacterController _d6fc9483b3f1f6541b4122c5b5318fff_14b743b2b20a42b79a2b5aca859d7a56_CommandTarget;

		private CharacterController _d6fc9483b3f1f6541b4122c5b5318fff_cd4ea39453ad4afdb2d4bca40a5e625e_CommandTarget;

		private CharacterController _d6fc9483b3f1f6541b4122c5b5318fff_921978b73d5c4972b1d8d7d1fcda81bb_CommandTarget;

		private CharacterController _d6fc9483b3f1f6541b4122c5b5318fff_dd0cead4fd3c4a60a26c7f9cdeebc039_CommandTarget;

		private CharacterController _d6fc9483b3f1f6541b4122c5b5318fff_9b057fc0a72d48a686bc222998fe1c66_CommandTarget;

		private CharacterController _d6fc9483b3f1f6541b4122c5b5318fff_a58793afaf214dc98f2bf653f2b6960f_CommandTarget;

		private CharacterController _d6fc9483b3f1f6541b4122c5b5318fff_bfbe7b983da94586bbfa73a150c5e342_CommandTarget;

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

		private void BakeCommandBinding__d6fc9483b3f1f6541b4122c5b5318fff_d9c329012b3245c1a3daab814ac54873(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d6fc9483b3f1f6541b4122c5b5318fff_d9c329012b3245c1a3daab814ac54873(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d6fc9483b3f1f6541b4122c5b5318fff_d9c329012b3245c1a3daab814ac54873(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d6fc9483b3f1f6541b4122c5b5318fff_d9c329012b3245c1a3daab814ac54873(_d6fc9483b3f1f6541b4122c5b5318fff_d9c329012b3245c1a3daab814ac54873 command)
		{
		}

		private void BakeCommandBinding__d6fc9483b3f1f6541b4122c5b5318fff_5f50c9e2266246cda5a1bc911b9b8fd4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d6fc9483b3f1f6541b4122c5b5318fff_5f50c9e2266246cda5a1bc911b9b8fd4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d6fc9483b3f1f6541b4122c5b5318fff_5f50c9e2266246cda5a1bc911b9b8fd4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d6fc9483b3f1f6541b4122c5b5318fff_5f50c9e2266246cda5a1bc911b9b8fd4(_d6fc9483b3f1f6541b4122c5b5318fff_5f50c9e2266246cda5a1bc911b9b8fd4 command)
		{
		}

		private void BakeCommandBinding__d6fc9483b3f1f6541b4122c5b5318fff_f530f0470adc4fb38c1af5e153282d78(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d6fc9483b3f1f6541b4122c5b5318fff_f530f0470adc4fb38c1af5e153282d78(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d6fc9483b3f1f6541b4122c5b5318fff_f530f0470adc4fb38c1af5e153282d78(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d6fc9483b3f1f6541b4122c5b5318fff_f530f0470adc4fb38c1af5e153282d78(_d6fc9483b3f1f6541b4122c5b5318fff_f530f0470adc4fb38c1af5e153282d78 command)
		{
		}

		private void BakeCommandBinding__d6fc9483b3f1f6541b4122c5b5318fff_795a332d2c2e4a2b9eecb5c58e78be65(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d6fc9483b3f1f6541b4122c5b5318fff_795a332d2c2e4a2b9eecb5c58e78be65(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d6fc9483b3f1f6541b4122c5b5318fff_795a332d2c2e4a2b9eecb5c58e78be65(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d6fc9483b3f1f6541b4122c5b5318fff_795a332d2c2e4a2b9eecb5c58e78be65(_d6fc9483b3f1f6541b4122c5b5318fff_795a332d2c2e4a2b9eecb5c58e78be65 command)
		{
		}

		private void BakeCommandBinding__d6fc9483b3f1f6541b4122c5b5318fff_73fe988920f742f882fafc17a2a5c34b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d6fc9483b3f1f6541b4122c5b5318fff_73fe988920f742f882fafc17a2a5c34b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d6fc9483b3f1f6541b4122c5b5318fff_73fe988920f742f882fafc17a2a5c34b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d6fc9483b3f1f6541b4122c5b5318fff_73fe988920f742f882fafc17a2a5c34b(_d6fc9483b3f1f6541b4122c5b5318fff_73fe988920f742f882fafc17a2a5c34b command)
		{
		}

		private void BakeCommandBinding__d6fc9483b3f1f6541b4122c5b5318fff_d69099979d2c48b196a9da6a4e1c756c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d6fc9483b3f1f6541b4122c5b5318fff_d69099979d2c48b196a9da6a4e1c756c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d6fc9483b3f1f6541b4122c5b5318fff_d69099979d2c48b196a9da6a4e1c756c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d6fc9483b3f1f6541b4122c5b5318fff_d69099979d2c48b196a9da6a4e1c756c(_d6fc9483b3f1f6541b4122c5b5318fff_d69099979d2c48b196a9da6a4e1c756c command)
		{
		}

		private void BakeCommandBinding__d6fc9483b3f1f6541b4122c5b5318fff_14b743b2b20a42b79a2b5aca859d7a56(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d6fc9483b3f1f6541b4122c5b5318fff_14b743b2b20a42b79a2b5aca859d7a56(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d6fc9483b3f1f6541b4122c5b5318fff_14b743b2b20a42b79a2b5aca859d7a56(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d6fc9483b3f1f6541b4122c5b5318fff_14b743b2b20a42b79a2b5aca859d7a56(_d6fc9483b3f1f6541b4122c5b5318fff_14b743b2b20a42b79a2b5aca859d7a56 command)
		{
		}

		private void BakeCommandBinding__d6fc9483b3f1f6541b4122c5b5318fff_cd4ea39453ad4afdb2d4bca40a5e625e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d6fc9483b3f1f6541b4122c5b5318fff_cd4ea39453ad4afdb2d4bca40a5e625e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d6fc9483b3f1f6541b4122c5b5318fff_cd4ea39453ad4afdb2d4bca40a5e625e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d6fc9483b3f1f6541b4122c5b5318fff_cd4ea39453ad4afdb2d4bca40a5e625e(_d6fc9483b3f1f6541b4122c5b5318fff_cd4ea39453ad4afdb2d4bca40a5e625e command)
		{
		}

		private void BakeCommandBinding__d6fc9483b3f1f6541b4122c5b5318fff_921978b73d5c4972b1d8d7d1fcda81bb(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d6fc9483b3f1f6541b4122c5b5318fff_921978b73d5c4972b1d8d7d1fcda81bb(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d6fc9483b3f1f6541b4122c5b5318fff_921978b73d5c4972b1d8d7d1fcda81bb(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d6fc9483b3f1f6541b4122c5b5318fff_921978b73d5c4972b1d8d7d1fcda81bb(_d6fc9483b3f1f6541b4122c5b5318fff_921978b73d5c4972b1d8d7d1fcda81bb command)
		{
		}

		private void BakeCommandBinding__d6fc9483b3f1f6541b4122c5b5318fff_dd0cead4fd3c4a60a26c7f9cdeebc039(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d6fc9483b3f1f6541b4122c5b5318fff_dd0cead4fd3c4a60a26c7f9cdeebc039(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d6fc9483b3f1f6541b4122c5b5318fff_dd0cead4fd3c4a60a26c7f9cdeebc039(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d6fc9483b3f1f6541b4122c5b5318fff_dd0cead4fd3c4a60a26c7f9cdeebc039(_d6fc9483b3f1f6541b4122c5b5318fff_dd0cead4fd3c4a60a26c7f9cdeebc039 command)
		{
		}

		private void BakeCommandBinding__d6fc9483b3f1f6541b4122c5b5318fff_9b057fc0a72d48a686bc222998fe1c66(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d6fc9483b3f1f6541b4122c5b5318fff_9b057fc0a72d48a686bc222998fe1c66(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d6fc9483b3f1f6541b4122c5b5318fff_9b057fc0a72d48a686bc222998fe1c66(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d6fc9483b3f1f6541b4122c5b5318fff_9b057fc0a72d48a686bc222998fe1c66(_d6fc9483b3f1f6541b4122c5b5318fff_9b057fc0a72d48a686bc222998fe1c66 command)
		{
		}

		private void BakeCommandBinding__d6fc9483b3f1f6541b4122c5b5318fff_a58793afaf214dc98f2bf653f2b6960f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d6fc9483b3f1f6541b4122c5b5318fff_a58793afaf214dc98f2bf653f2b6960f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d6fc9483b3f1f6541b4122c5b5318fff_a58793afaf214dc98f2bf653f2b6960f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d6fc9483b3f1f6541b4122c5b5318fff_a58793afaf214dc98f2bf653f2b6960f(_d6fc9483b3f1f6541b4122c5b5318fff_a58793afaf214dc98f2bf653f2b6960f command)
		{
		}

		private void BakeCommandBinding__d6fc9483b3f1f6541b4122c5b5318fff_bfbe7b983da94586bbfa73a150c5e342(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d6fc9483b3f1f6541b4122c5b5318fff_bfbe7b983da94586bbfa73a150c5e342(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d6fc9483b3f1f6541b4122c5b5318fff_bfbe7b983da94586bbfa73a150c5e342(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d6fc9483b3f1f6541b4122c5b5318fff_bfbe7b983da94586bbfa73a150c5e342(_d6fc9483b3f1f6541b4122c5b5318fff_bfbe7b983da94586bbfa73a150c5e342 command)
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
