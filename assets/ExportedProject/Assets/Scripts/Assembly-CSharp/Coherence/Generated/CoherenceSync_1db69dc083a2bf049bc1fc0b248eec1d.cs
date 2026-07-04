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
	public class CoherenceSync_1db69dc083a2bf049bc1fc0b248eec1d : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _1db69dc083a2bf049bc1fc0b248eec1d_6d65aec45d664e2aaebb96b37f314439_CommandTarget;

		private CharacterController _1db69dc083a2bf049bc1fc0b248eec1d_7f2e55aa550d4eb3ad5849e8da9bf87a_CommandTarget;

		private CharacterController _1db69dc083a2bf049bc1fc0b248eec1d_f5be1eb4d9914af094e74c614fe60ac6_CommandTarget;

		private CharacterController _1db69dc083a2bf049bc1fc0b248eec1d_8bf82e114a2a43ab8c9e174f3af66e9e_CommandTarget;

		private CharacterController _1db69dc083a2bf049bc1fc0b248eec1d_bd3f020db5e94853a4a850b0097b0fcd_CommandTarget;

		private CharacterController _1db69dc083a2bf049bc1fc0b248eec1d_0c4953f6c5404843823fbc7226408632_CommandTarget;

		private CharacterController _1db69dc083a2bf049bc1fc0b248eec1d_34e40f1efacb430885362ac0f265b06e_CommandTarget;

		private CharacterController _1db69dc083a2bf049bc1fc0b248eec1d_dda491fdc4974668b412ef4cadc7fd29_CommandTarget;

		private CharacterController _1db69dc083a2bf049bc1fc0b248eec1d_76da48c212234a8a86c7c5579053e230_CommandTarget;

		private CharacterController _1db69dc083a2bf049bc1fc0b248eec1d_c0aa489fc6c846a7bdd313e639d0fdf8_CommandTarget;

		private CharacterController _1db69dc083a2bf049bc1fc0b248eec1d_f747c88893c248f0a51a256839f6ea7f_CommandTarget;

		private CharacterController _1db69dc083a2bf049bc1fc0b248eec1d_a4777d47dec5405fa2e907dffd7c9c56_CommandTarget;

		private CharacterController_EX_Torino _1db69dc083a2bf049bc1fc0b248eec1d_820c55bbcf954a02bf3402e36f1fb149_CommandTarget;

		private CharacterController _1db69dc083a2bf049bc1fc0b248eec1d_33a0e4cb73d04861abe8361a5803052a_CommandTarget;

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

		private void BakeCommandBinding__1db69dc083a2bf049bc1fc0b248eec1d_6d65aec45d664e2aaebb96b37f314439(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1db69dc083a2bf049bc1fc0b248eec1d_6d65aec45d664e2aaebb96b37f314439(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1db69dc083a2bf049bc1fc0b248eec1d_6d65aec45d664e2aaebb96b37f314439(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1db69dc083a2bf049bc1fc0b248eec1d_6d65aec45d664e2aaebb96b37f314439(_1db69dc083a2bf049bc1fc0b248eec1d_6d65aec45d664e2aaebb96b37f314439 command)
		{
		}

		private void BakeCommandBinding__1db69dc083a2bf049bc1fc0b248eec1d_7f2e55aa550d4eb3ad5849e8da9bf87a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1db69dc083a2bf049bc1fc0b248eec1d_7f2e55aa550d4eb3ad5849e8da9bf87a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1db69dc083a2bf049bc1fc0b248eec1d_7f2e55aa550d4eb3ad5849e8da9bf87a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1db69dc083a2bf049bc1fc0b248eec1d_7f2e55aa550d4eb3ad5849e8da9bf87a(_1db69dc083a2bf049bc1fc0b248eec1d_7f2e55aa550d4eb3ad5849e8da9bf87a command)
		{
		}

		private void BakeCommandBinding__1db69dc083a2bf049bc1fc0b248eec1d_f5be1eb4d9914af094e74c614fe60ac6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1db69dc083a2bf049bc1fc0b248eec1d_f5be1eb4d9914af094e74c614fe60ac6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1db69dc083a2bf049bc1fc0b248eec1d_f5be1eb4d9914af094e74c614fe60ac6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1db69dc083a2bf049bc1fc0b248eec1d_f5be1eb4d9914af094e74c614fe60ac6(_1db69dc083a2bf049bc1fc0b248eec1d_f5be1eb4d9914af094e74c614fe60ac6 command)
		{
		}

		private void BakeCommandBinding__1db69dc083a2bf049bc1fc0b248eec1d_8bf82e114a2a43ab8c9e174f3af66e9e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1db69dc083a2bf049bc1fc0b248eec1d_8bf82e114a2a43ab8c9e174f3af66e9e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1db69dc083a2bf049bc1fc0b248eec1d_8bf82e114a2a43ab8c9e174f3af66e9e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1db69dc083a2bf049bc1fc0b248eec1d_8bf82e114a2a43ab8c9e174f3af66e9e(_1db69dc083a2bf049bc1fc0b248eec1d_8bf82e114a2a43ab8c9e174f3af66e9e command)
		{
		}

		private void BakeCommandBinding__1db69dc083a2bf049bc1fc0b248eec1d_bd3f020db5e94853a4a850b0097b0fcd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1db69dc083a2bf049bc1fc0b248eec1d_bd3f020db5e94853a4a850b0097b0fcd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1db69dc083a2bf049bc1fc0b248eec1d_bd3f020db5e94853a4a850b0097b0fcd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1db69dc083a2bf049bc1fc0b248eec1d_bd3f020db5e94853a4a850b0097b0fcd(_1db69dc083a2bf049bc1fc0b248eec1d_bd3f020db5e94853a4a850b0097b0fcd command)
		{
		}

		private void BakeCommandBinding__1db69dc083a2bf049bc1fc0b248eec1d_0c4953f6c5404843823fbc7226408632(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1db69dc083a2bf049bc1fc0b248eec1d_0c4953f6c5404843823fbc7226408632(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1db69dc083a2bf049bc1fc0b248eec1d_0c4953f6c5404843823fbc7226408632(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1db69dc083a2bf049bc1fc0b248eec1d_0c4953f6c5404843823fbc7226408632(_1db69dc083a2bf049bc1fc0b248eec1d_0c4953f6c5404843823fbc7226408632 command)
		{
		}

		private void BakeCommandBinding__1db69dc083a2bf049bc1fc0b248eec1d_34e40f1efacb430885362ac0f265b06e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1db69dc083a2bf049bc1fc0b248eec1d_34e40f1efacb430885362ac0f265b06e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1db69dc083a2bf049bc1fc0b248eec1d_34e40f1efacb430885362ac0f265b06e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1db69dc083a2bf049bc1fc0b248eec1d_34e40f1efacb430885362ac0f265b06e(_1db69dc083a2bf049bc1fc0b248eec1d_34e40f1efacb430885362ac0f265b06e command)
		{
		}

		private void BakeCommandBinding__1db69dc083a2bf049bc1fc0b248eec1d_dda491fdc4974668b412ef4cadc7fd29(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1db69dc083a2bf049bc1fc0b248eec1d_dda491fdc4974668b412ef4cadc7fd29(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1db69dc083a2bf049bc1fc0b248eec1d_dda491fdc4974668b412ef4cadc7fd29(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1db69dc083a2bf049bc1fc0b248eec1d_dda491fdc4974668b412ef4cadc7fd29(_1db69dc083a2bf049bc1fc0b248eec1d_dda491fdc4974668b412ef4cadc7fd29 command)
		{
		}

		private void BakeCommandBinding__1db69dc083a2bf049bc1fc0b248eec1d_76da48c212234a8a86c7c5579053e230(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1db69dc083a2bf049bc1fc0b248eec1d_76da48c212234a8a86c7c5579053e230(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1db69dc083a2bf049bc1fc0b248eec1d_76da48c212234a8a86c7c5579053e230(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1db69dc083a2bf049bc1fc0b248eec1d_76da48c212234a8a86c7c5579053e230(_1db69dc083a2bf049bc1fc0b248eec1d_76da48c212234a8a86c7c5579053e230 command)
		{
		}

		private void BakeCommandBinding__1db69dc083a2bf049bc1fc0b248eec1d_c0aa489fc6c846a7bdd313e639d0fdf8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1db69dc083a2bf049bc1fc0b248eec1d_c0aa489fc6c846a7bdd313e639d0fdf8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1db69dc083a2bf049bc1fc0b248eec1d_c0aa489fc6c846a7bdd313e639d0fdf8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1db69dc083a2bf049bc1fc0b248eec1d_c0aa489fc6c846a7bdd313e639d0fdf8(_1db69dc083a2bf049bc1fc0b248eec1d_c0aa489fc6c846a7bdd313e639d0fdf8 command)
		{
		}

		private void BakeCommandBinding__1db69dc083a2bf049bc1fc0b248eec1d_f747c88893c248f0a51a256839f6ea7f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1db69dc083a2bf049bc1fc0b248eec1d_f747c88893c248f0a51a256839f6ea7f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1db69dc083a2bf049bc1fc0b248eec1d_f747c88893c248f0a51a256839f6ea7f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1db69dc083a2bf049bc1fc0b248eec1d_f747c88893c248f0a51a256839f6ea7f(_1db69dc083a2bf049bc1fc0b248eec1d_f747c88893c248f0a51a256839f6ea7f command)
		{
		}

		private void BakeCommandBinding__1db69dc083a2bf049bc1fc0b248eec1d_a4777d47dec5405fa2e907dffd7c9c56(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1db69dc083a2bf049bc1fc0b248eec1d_a4777d47dec5405fa2e907dffd7c9c56(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1db69dc083a2bf049bc1fc0b248eec1d_a4777d47dec5405fa2e907dffd7c9c56(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1db69dc083a2bf049bc1fc0b248eec1d_a4777d47dec5405fa2e907dffd7c9c56(_1db69dc083a2bf049bc1fc0b248eec1d_a4777d47dec5405fa2e907dffd7c9c56 command)
		{
		}

		private void BakeCommandBinding__1db69dc083a2bf049bc1fc0b248eec1d_820c55bbcf954a02bf3402e36f1fb149(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1db69dc083a2bf049bc1fc0b248eec1d_820c55bbcf954a02bf3402e36f1fb149(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1db69dc083a2bf049bc1fc0b248eec1d_820c55bbcf954a02bf3402e36f1fb149(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1db69dc083a2bf049bc1fc0b248eec1d_820c55bbcf954a02bf3402e36f1fb149(_1db69dc083a2bf049bc1fc0b248eec1d_820c55bbcf954a02bf3402e36f1fb149 command)
		{
		}

		private void BakeCommandBinding__1db69dc083a2bf049bc1fc0b248eec1d_33a0e4cb73d04861abe8361a5803052a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1db69dc083a2bf049bc1fc0b248eec1d_33a0e4cb73d04861abe8361a5803052a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1db69dc083a2bf049bc1fc0b248eec1d_33a0e4cb73d04861abe8361a5803052a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1db69dc083a2bf049bc1fc0b248eec1d_33a0e4cb73d04861abe8361a5803052a(_1db69dc083a2bf049bc1fc0b248eec1d_33a0e4cb73d04861abe8361a5803052a command)
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
