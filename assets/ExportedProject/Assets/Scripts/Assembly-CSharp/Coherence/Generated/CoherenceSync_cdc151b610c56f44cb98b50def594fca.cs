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
	public class CoherenceSync_cdc151b610c56f44cb98b50def594fca : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _cdc151b610c56f44cb98b50def594fca_de4d1c98530b4ec28dc7e52f299afa97_CommandTarget;

		private CharacterController _cdc151b610c56f44cb98b50def594fca_b20a4ec6057d4ca2a62add214e643cea_CommandTarget;

		private CharacterController _cdc151b610c56f44cb98b50def594fca_d3432115ee6d4f7ab13898ba76c7e37c_CommandTarget;

		private CharacterController _cdc151b610c56f44cb98b50def594fca_b8cbfc48f0ac4ceabec9ecd1a397560e_CommandTarget;

		private CharacterController _cdc151b610c56f44cb98b50def594fca_c9b2e95a852b4c22b1153559e7be9809_CommandTarget;

		private CharacterController _cdc151b610c56f44cb98b50def594fca_537f064b2aa44180aeb740a7d34e8a11_CommandTarget;

		private CharacterController _cdc151b610c56f44cb98b50def594fca_47cd782d6e8b4f48bfb50280558cf37d_CommandTarget;

		private CharacterController _cdc151b610c56f44cb98b50def594fca_0cdb1ab60ee740a1ad903bb14cd8e72c_CommandTarget;

		private CharacterController _cdc151b610c56f44cb98b50def594fca_e7f0de773a14469ca213b8279b2bff6d_CommandTarget;

		private CharacterController _cdc151b610c56f44cb98b50def594fca_fd1eb40701bd4edfbea6a0bd036b538b_CommandTarget;

		private CharacterController _cdc151b610c56f44cb98b50def594fca_1227a7abe14d4be297f0486dbe57cc21_CommandTarget;

		private CharacterController _cdc151b610c56f44cb98b50def594fca_f46bb9c020dd4b0caa215e0ae5652bcc_CommandTarget;

		private CharacterController _cdc151b610c56f44cb98b50def594fca_f57d77c0e5b24858b7b53659f8aeffcd_CommandTarget;

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

		private void BakeCommandBinding__cdc151b610c56f44cb98b50def594fca_de4d1c98530b4ec28dc7e52f299afa97(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cdc151b610c56f44cb98b50def594fca_de4d1c98530b4ec28dc7e52f299afa97(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cdc151b610c56f44cb98b50def594fca_de4d1c98530b4ec28dc7e52f299afa97(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cdc151b610c56f44cb98b50def594fca_de4d1c98530b4ec28dc7e52f299afa97(_cdc151b610c56f44cb98b50def594fca_de4d1c98530b4ec28dc7e52f299afa97 command)
		{
		}

		private void BakeCommandBinding__cdc151b610c56f44cb98b50def594fca_b20a4ec6057d4ca2a62add214e643cea(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cdc151b610c56f44cb98b50def594fca_b20a4ec6057d4ca2a62add214e643cea(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cdc151b610c56f44cb98b50def594fca_b20a4ec6057d4ca2a62add214e643cea(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cdc151b610c56f44cb98b50def594fca_b20a4ec6057d4ca2a62add214e643cea(_cdc151b610c56f44cb98b50def594fca_b20a4ec6057d4ca2a62add214e643cea command)
		{
		}

		private void BakeCommandBinding__cdc151b610c56f44cb98b50def594fca_d3432115ee6d4f7ab13898ba76c7e37c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cdc151b610c56f44cb98b50def594fca_d3432115ee6d4f7ab13898ba76c7e37c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cdc151b610c56f44cb98b50def594fca_d3432115ee6d4f7ab13898ba76c7e37c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cdc151b610c56f44cb98b50def594fca_d3432115ee6d4f7ab13898ba76c7e37c(_cdc151b610c56f44cb98b50def594fca_d3432115ee6d4f7ab13898ba76c7e37c command)
		{
		}

		private void BakeCommandBinding__cdc151b610c56f44cb98b50def594fca_b8cbfc48f0ac4ceabec9ecd1a397560e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cdc151b610c56f44cb98b50def594fca_b8cbfc48f0ac4ceabec9ecd1a397560e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cdc151b610c56f44cb98b50def594fca_b8cbfc48f0ac4ceabec9ecd1a397560e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cdc151b610c56f44cb98b50def594fca_b8cbfc48f0ac4ceabec9ecd1a397560e(_cdc151b610c56f44cb98b50def594fca_b8cbfc48f0ac4ceabec9ecd1a397560e command)
		{
		}

		private void BakeCommandBinding__cdc151b610c56f44cb98b50def594fca_c9b2e95a852b4c22b1153559e7be9809(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cdc151b610c56f44cb98b50def594fca_c9b2e95a852b4c22b1153559e7be9809(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cdc151b610c56f44cb98b50def594fca_c9b2e95a852b4c22b1153559e7be9809(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cdc151b610c56f44cb98b50def594fca_c9b2e95a852b4c22b1153559e7be9809(_cdc151b610c56f44cb98b50def594fca_c9b2e95a852b4c22b1153559e7be9809 command)
		{
		}

		private void BakeCommandBinding__cdc151b610c56f44cb98b50def594fca_537f064b2aa44180aeb740a7d34e8a11(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cdc151b610c56f44cb98b50def594fca_537f064b2aa44180aeb740a7d34e8a11(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cdc151b610c56f44cb98b50def594fca_537f064b2aa44180aeb740a7d34e8a11(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cdc151b610c56f44cb98b50def594fca_537f064b2aa44180aeb740a7d34e8a11(_cdc151b610c56f44cb98b50def594fca_537f064b2aa44180aeb740a7d34e8a11 command)
		{
		}

		private void BakeCommandBinding__cdc151b610c56f44cb98b50def594fca_47cd782d6e8b4f48bfb50280558cf37d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cdc151b610c56f44cb98b50def594fca_47cd782d6e8b4f48bfb50280558cf37d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cdc151b610c56f44cb98b50def594fca_47cd782d6e8b4f48bfb50280558cf37d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cdc151b610c56f44cb98b50def594fca_47cd782d6e8b4f48bfb50280558cf37d(_cdc151b610c56f44cb98b50def594fca_47cd782d6e8b4f48bfb50280558cf37d command)
		{
		}

		private void BakeCommandBinding__cdc151b610c56f44cb98b50def594fca_0cdb1ab60ee740a1ad903bb14cd8e72c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cdc151b610c56f44cb98b50def594fca_0cdb1ab60ee740a1ad903bb14cd8e72c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cdc151b610c56f44cb98b50def594fca_0cdb1ab60ee740a1ad903bb14cd8e72c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cdc151b610c56f44cb98b50def594fca_0cdb1ab60ee740a1ad903bb14cd8e72c(_cdc151b610c56f44cb98b50def594fca_0cdb1ab60ee740a1ad903bb14cd8e72c command)
		{
		}

		private void BakeCommandBinding__cdc151b610c56f44cb98b50def594fca_e7f0de773a14469ca213b8279b2bff6d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cdc151b610c56f44cb98b50def594fca_e7f0de773a14469ca213b8279b2bff6d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cdc151b610c56f44cb98b50def594fca_e7f0de773a14469ca213b8279b2bff6d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cdc151b610c56f44cb98b50def594fca_e7f0de773a14469ca213b8279b2bff6d(_cdc151b610c56f44cb98b50def594fca_e7f0de773a14469ca213b8279b2bff6d command)
		{
		}

		private void BakeCommandBinding__cdc151b610c56f44cb98b50def594fca_fd1eb40701bd4edfbea6a0bd036b538b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cdc151b610c56f44cb98b50def594fca_fd1eb40701bd4edfbea6a0bd036b538b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cdc151b610c56f44cb98b50def594fca_fd1eb40701bd4edfbea6a0bd036b538b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cdc151b610c56f44cb98b50def594fca_fd1eb40701bd4edfbea6a0bd036b538b(_cdc151b610c56f44cb98b50def594fca_fd1eb40701bd4edfbea6a0bd036b538b command)
		{
		}

		private void BakeCommandBinding__cdc151b610c56f44cb98b50def594fca_1227a7abe14d4be297f0486dbe57cc21(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cdc151b610c56f44cb98b50def594fca_1227a7abe14d4be297f0486dbe57cc21(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cdc151b610c56f44cb98b50def594fca_1227a7abe14d4be297f0486dbe57cc21(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cdc151b610c56f44cb98b50def594fca_1227a7abe14d4be297f0486dbe57cc21(_cdc151b610c56f44cb98b50def594fca_1227a7abe14d4be297f0486dbe57cc21 command)
		{
		}

		private void BakeCommandBinding__cdc151b610c56f44cb98b50def594fca_f46bb9c020dd4b0caa215e0ae5652bcc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cdc151b610c56f44cb98b50def594fca_f46bb9c020dd4b0caa215e0ae5652bcc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cdc151b610c56f44cb98b50def594fca_f46bb9c020dd4b0caa215e0ae5652bcc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cdc151b610c56f44cb98b50def594fca_f46bb9c020dd4b0caa215e0ae5652bcc(_cdc151b610c56f44cb98b50def594fca_f46bb9c020dd4b0caa215e0ae5652bcc command)
		{
		}

		private void BakeCommandBinding__cdc151b610c56f44cb98b50def594fca_f57d77c0e5b24858b7b53659f8aeffcd(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__cdc151b610c56f44cb98b50def594fca_f57d77c0e5b24858b7b53659f8aeffcd(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__cdc151b610c56f44cb98b50def594fca_f57d77c0e5b24858b7b53659f8aeffcd(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__cdc151b610c56f44cb98b50def594fca_f57d77c0e5b24858b7b53659f8aeffcd(_cdc151b610c56f44cb98b50def594fca_f57d77c0e5b24858b7b53659f8aeffcd command)
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
