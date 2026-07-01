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
	public class CoherenceSync_071db6b70bf5ea74c98c3ac0c7477408 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _071db6b70bf5ea74c98c3ac0c7477408_a89702066f7b4ceaa3792272c29ab156_CommandTarget;

		private CharacterController _071db6b70bf5ea74c98c3ac0c7477408_3b42537c91f04df1a5f5b19fb466abe4_CommandTarget;

		private CharacterController _071db6b70bf5ea74c98c3ac0c7477408_3454a87321a44447af0b787fb7062d90_CommandTarget;

		private CharacterController _071db6b70bf5ea74c98c3ac0c7477408_a2136de2ac364f31b7e260c86af39cea_CommandTarget;

		private CharacterController _071db6b70bf5ea74c98c3ac0c7477408_219f328da8d44c4f880311267ab44922_CommandTarget;

		private CharacterController _071db6b70bf5ea74c98c3ac0c7477408_eb30b91576c64e1b8c668e584259a228_CommandTarget;

		private CharacterController _071db6b70bf5ea74c98c3ac0c7477408_01ddc207bc9f4f1390afa10f9ab8ef74_CommandTarget;

		private CharacterController _071db6b70bf5ea74c98c3ac0c7477408_5b7a014eea5d40f78e80735b042cf069_CommandTarget;

		private CharacterController _071db6b70bf5ea74c98c3ac0c7477408_0caf962cace44506b16dcc8ec9c22122_CommandTarget;

		private CharacterController _071db6b70bf5ea74c98c3ac0c7477408_90c203bda7524f44a3bd7ec7398bf596_CommandTarget;

		private CharacterController _071db6b70bf5ea74c98c3ac0c7477408_ac25811b704045cd951e119a74d0ff7e_CommandTarget;

		private CharacterController _071db6b70bf5ea74c98c3ac0c7477408_64aef7435437456d8fc7b2288772d916_CommandTarget;

		private CharacterController _071db6b70bf5ea74c98c3ac0c7477408_807c00e8eef94845893132745fe88aa4_CommandTarget;

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

		private void BakeCommandBinding__071db6b70bf5ea74c98c3ac0c7477408_a89702066f7b4ceaa3792272c29ab156(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__071db6b70bf5ea74c98c3ac0c7477408_a89702066f7b4ceaa3792272c29ab156(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__071db6b70bf5ea74c98c3ac0c7477408_a89702066f7b4ceaa3792272c29ab156(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__071db6b70bf5ea74c98c3ac0c7477408_a89702066f7b4ceaa3792272c29ab156(_071db6b70bf5ea74c98c3ac0c7477408_a89702066f7b4ceaa3792272c29ab156 command)
		{
		}

		private void BakeCommandBinding__071db6b70bf5ea74c98c3ac0c7477408_3b42537c91f04df1a5f5b19fb466abe4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__071db6b70bf5ea74c98c3ac0c7477408_3b42537c91f04df1a5f5b19fb466abe4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__071db6b70bf5ea74c98c3ac0c7477408_3b42537c91f04df1a5f5b19fb466abe4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__071db6b70bf5ea74c98c3ac0c7477408_3b42537c91f04df1a5f5b19fb466abe4(_071db6b70bf5ea74c98c3ac0c7477408_3b42537c91f04df1a5f5b19fb466abe4 command)
		{
		}

		private void BakeCommandBinding__071db6b70bf5ea74c98c3ac0c7477408_3454a87321a44447af0b787fb7062d90(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__071db6b70bf5ea74c98c3ac0c7477408_3454a87321a44447af0b787fb7062d90(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__071db6b70bf5ea74c98c3ac0c7477408_3454a87321a44447af0b787fb7062d90(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__071db6b70bf5ea74c98c3ac0c7477408_3454a87321a44447af0b787fb7062d90(_071db6b70bf5ea74c98c3ac0c7477408_3454a87321a44447af0b787fb7062d90 command)
		{
		}

		private void BakeCommandBinding__071db6b70bf5ea74c98c3ac0c7477408_a2136de2ac364f31b7e260c86af39cea(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__071db6b70bf5ea74c98c3ac0c7477408_a2136de2ac364f31b7e260c86af39cea(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__071db6b70bf5ea74c98c3ac0c7477408_a2136de2ac364f31b7e260c86af39cea(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__071db6b70bf5ea74c98c3ac0c7477408_a2136de2ac364f31b7e260c86af39cea(_071db6b70bf5ea74c98c3ac0c7477408_a2136de2ac364f31b7e260c86af39cea command)
		{
		}

		private void BakeCommandBinding__071db6b70bf5ea74c98c3ac0c7477408_219f328da8d44c4f880311267ab44922(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__071db6b70bf5ea74c98c3ac0c7477408_219f328da8d44c4f880311267ab44922(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__071db6b70bf5ea74c98c3ac0c7477408_219f328da8d44c4f880311267ab44922(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__071db6b70bf5ea74c98c3ac0c7477408_219f328da8d44c4f880311267ab44922(_071db6b70bf5ea74c98c3ac0c7477408_219f328da8d44c4f880311267ab44922 command)
		{
		}

		private void BakeCommandBinding__071db6b70bf5ea74c98c3ac0c7477408_eb30b91576c64e1b8c668e584259a228(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__071db6b70bf5ea74c98c3ac0c7477408_eb30b91576c64e1b8c668e584259a228(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__071db6b70bf5ea74c98c3ac0c7477408_eb30b91576c64e1b8c668e584259a228(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__071db6b70bf5ea74c98c3ac0c7477408_eb30b91576c64e1b8c668e584259a228(_071db6b70bf5ea74c98c3ac0c7477408_eb30b91576c64e1b8c668e584259a228 command)
		{
		}

		private void BakeCommandBinding__071db6b70bf5ea74c98c3ac0c7477408_01ddc207bc9f4f1390afa10f9ab8ef74(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__071db6b70bf5ea74c98c3ac0c7477408_01ddc207bc9f4f1390afa10f9ab8ef74(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__071db6b70bf5ea74c98c3ac0c7477408_01ddc207bc9f4f1390afa10f9ab8ef74(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__071db6b70bf5ea74c98c3ac0c7477408_01ddc207bc9f4f1390afa10f9ab8ef74(_071db6b70bf5ea74c98c3ac0c7477408_01ddc207bc9f4f1390afa10f9ab8ef74 command)
		{
		}

		private void BakeCommandBinding__071db6b70bf5ea74c98c3ac0c7477408_5b7a014eea5d40f78e80735b042cf069(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__071db6b70bf5ea74c98c3ac0c7477408_5b7a014eea5d40f78e80735b042cf069(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__071db6b70bf5ea74c98c3ac0c7477408_5b7a014eea5d40f78e80735b042cf069(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__071db6b70bf5ea74c98c3ac0c7477408_5b7a014eea5d40f78e80735b042cf069(_071db6b70bf5ea74c98c3ac0c7477408_5b7a014eea5d40f78e80735b042cf069 command)
		{
		}

		private void BakeCommandBinding__071db6b70bf5ea74c98c3ac0c7477408_0caf962cace44506b16dcc8ec9c22122(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__071db6b70bf5ea74c98c3ac0c7477408_0caf962cace44506b16dcc8ec9c22122(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__071db6b70bf5ea74c98c3ac0c7477408_0caf962cace44506b16dcc8ec9c22122(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__071db6b70bf5ea74c98c3ac0c7477408_0caf962cace44506b16dcc8ec9c22122(_071db6b70bf5ea74c98c3ac0c7477408_0caf962cace44506b16dcc8ec9c22122 command)
		{
		}

		private void BakeCommandBinding__071db6b70bf5ea74c98c3ac0c7477408_90c203bda7524f44a3bd7ec7398bf596(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__071db6b70bf5ea74c98c3ac0c7477408_90c203bda7524f44a3bd7ec7398bf596(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__071db6b70bf5ea74c98c3ac0c7477408_90c203bda7524f44a3bd7ec7398bf596(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__071db6b70bf5ea74c98c3ac0c7477408_90c203bda7524f44a3bd7ec7398bf596(_071db6b70bf5ea74c98c3ac0c7477408_90c203bda7524f44a3bd7ec7398bf596 command)
		{
		}

		private void BakeCommandBinding__071db6b70bf5ea74c98c3ac0c7477408_ac25811b704045cd951e119a74d0ff7e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__071db6b70bf5ea74c98c3ac0c7477408_ac25811b704045cd951e119a74d0ff7e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__071db6b70bf5ea74c98c3ac0c7477408_ac25811b704045cd951e119a74d0ff7e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__071db6b70bf5ea74c98c3ac0c7477408_ac25811b704045cd951e119a74d0ff7e(_071db6b70bf5ea74c98c3ac0c7477408_ac25811b704045cd951e119a74d0ff7e command)
		{
		}

		private void BakeCommandBinding__071db6b70bf5ea74c98c3ac0c7477408_64aef7435437456d8fc7b2288772d916(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__071db6b70bf5ea74c98c3ac0c7477408_64aef7435437456d8fc7b2288772d916(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__071db6b70bf5ea74c98c3ac0c7477408_64aef7435437456d8fc7b2288772d916(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__071db6b70bf5ea74c98c3ac0c7477408_64aef7435437456d8fc7b2288772d916(_071db6b70bf5ea74c98c3ac0c7477408_64aef7435437456d8fc7b2288772d916 command)
		{
		}

		private void BakeCommandBinding__071db6b70bf5ea74c98c3ac0c7477408_807c00e8eef94845893132745fe88aa4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__071db6b70bf5ea74c98c3ac0c7477408_807c00e8eef94845893132745fe88aa4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__071db6b70bf5ea74c98c3ac0c7477408_807c00e8eef94845893132745fe88aa4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__071db6b70bf5ea74c98c3ac0c7477408_807c00e8eef94845893132745fe88aa4(_071db6b70bf5ea74c98c3ac0c7477408_807c00e8eef94845893132745fe88aa4 command)
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
