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
	public class CoherenceSync_66ffafd329bbe1b47b4184bcf5af66bd : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _66ffafd329bbe1b47b4184bcf5af66bd_35b2fbe3560341099d05f0917a2b648c_CommandTarget;

		private CharacterController _66ffafd329bbe1b47b4184bcf5af66bd_8389005852e642708908bd7932036090_CommandTarget;

		private CharacterController _66ffafd329bbe1b47b4184bcf5af66bd_2bcc8fd47f904e2085995edac4b8bdf8_CommandTarget;

		private CharacterController _66ffafd329bbe1b47b4184bcf5af66bd_4a96014f6b1546e2b1d7943e05d75a4c_CommandTarget;

		private CharacterController _66ffafd329bbe1b47b4184bcf5af66bd_db5cac149e9547c3878c16996b65bf26_CommandTarget;

		private CharacterController _66ffafd329bbe1b47b4184bcf5af66bd_f360bf3914a04f338f7221417de1f924_CommandTarget;

		private CharacterController _66ffafd329bbe1b47b4184bcf5af66bd_de25750520e744659ca4d7a3947b0a6f_CommandTarget;

		private CharacterController _66ffafd329bbe1b47b4184bcf5af66bd_1fb69705e0e4410890417edb7ecacf03_CommandTarget;

		private CharacterController _66ffafd329bbe1b47b4184bcf5af66bd_133fb2d3f0eb4a459684ef3b584a8172_CommandTarget;

		private CharacterController _66ffafd329bbe1b47b4184bcf5af66bd_8fe08dd0aa284e209cc5e7c83465625b_CommandTarget;

		private CharacterController _66ffafd329bbe1b47b4184bcf5af66bd_b1d563b0ad014103b08044284d089113_CommandTarget;

		private CharacterController _66ffafd329bbe1b47b4184bcf5af66bd_3bd31cc407664f1b846f1edd7863228e_CommandTarget;

		private CharacterController _66ffafd329bbe1b47b4184bcf5af66bd_6c702309f3194b8bb19f1f794dafe094_CommandTarget;

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

		private void BakeCommandBinding__66ffafd329bbe1b47b4184bcf5af66bd_35b2fbe3560341099d05f0917a2b648c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__66ffafd329bbe1b47b4184bcf5af66bd_35b2fbe3560341099d05f0917a2b648c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__66ffafd329bbe1b47b4184bcf5af66bd_35b2fbe3560341099d05f0917a2b648c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__66ffafd329bbe1b47b4184bcf5af66bd_35b2fbe3560341099d05f0917a2b648c(_66ffafd329bbe1b47b4184bcf5af66bd_35b2fbe3560341099d05f0917a2b648c command)
		{
		}

		private void BakeCommandBinding__66ffafd329bbe1b47b4184bcf5af66bd_8389005852e642708908bd7932036090(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__66ffafd329bbe1b47b4184bcf5af66bd_8389005852e642708908bd7932036090(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__66ffafd329bbe1b47b4184bcf5af66bd_8389005852e642708908bd7932036090(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__66ffafd329bbe1b47b4184bcf5af66bd_8389005852e642708908bd7932036090(_66ffafd329bbe1b47b4184bcf5af66bd_8389005852e642708908bd7932036090 command)
		{
		}

		private void BakeCommandBinding__66ffafd329bbe1b47b4184bcf5af66bd_2bcc8fd47f904e2085995edac4b8bdf8(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__66ffafd329bbe1b47b4184bcf5af66bd_2bcc8fd47f904e2085995edac4b8bdf8(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__66ffafd329bbe1b47b4184bcf5af66bd_2bcc8fd47f904e2085995edac4b8bdf8(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__66ffafd329bbe1b47b4184bcf5af66bd_2bcc8fd47f904e2085995edac4b8bdf8(_66ffafd329bbe1b47b4184bcf5af66bd_2bcc8fd47f904e2085995edac4b8bdf8 command)
		{
		}

		private void BakeCommandBinding__66ffafd329bbe1b47b4184bcf5af66bd_4a96014f6b1546e2b1d7943e05d75a4c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__66ffafd329bbe1b47b4184bcf5af66bd_4a96014f6b1546e2b1d7943e05d75a4c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__66ffafd329bbe1b47b4184bcf5af66bd_4a96014f6b1546e2b1d7943e05d75a4c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__66ffafd329bbe1b47b4184bcf5af66bd_4a96014f6b1546e2b1d7943e05d75a4c(_66ffafd329bbe1b47b4184bcf5af66bd_4a96014f6b1546e2b1d7943e05d75a4c command)
		{
		}

		private void BakeCommandBinding__66ffafd329bbe1b47b4184bcf5af66bd_db5cac149e9547c3878c16996b65bf26(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__66ffafd329bbe1b47b4184bcf5af66bd_db5cac149e9547c3878c16996b65bf26(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__66ffafd329bbe1b47b4184bcf5af66bd_db5cac149e9547c3878c16996b65bf26(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__66ffafd329bbe1b47b4184bcf5af66bd_db5cac149e9547c3878c16996b65bf26(_66ffafd329bbe1b47b4184bcf5af66bd_db5cac149e9547c3878c16996b65bf26 command)
		{
		}

		private void BakeCommandBinding__66ffafd329bbe1b47b4184bcf5af66bd_f360bf3914a04f338f7221417de1f924(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__66ffafd329bbe1b47b4184bcf5af66bd_f360bf3914a04f338f7221417de1f924(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__66ffafd329bbe1b47b4184bcf5af66bd_f360bf3914a04f338f7221417de1f924(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__66ffafd329bbe1b47b4184bcf5af66bd_f360bf3914a04f338f7221417de1f924(_66ffafd329bbe1b47b4184bcf5af66bd_f360bf3914a04f338f7221417de1f924 command)
		{
		}

		private void BakeCommandBinding__66ffafd329bbe1b47b4184bcf5af66bd_de25750520e744659ca4d7a3947b0a6f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__66ffafd329bbe1b47b4184bcf5af66bd_de25750520e744659ca4d7a3947b0a6f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__66ffafd329bbe1b47b4184bcf5af66bd_de25750520e744659ca4d7a3947b0a6f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__66ffafd329bbe1b47b4184bcf5af66bd_de25750520e744659ca4d7a3947b0a6f(_66ffafd329bbe1b47b4184bcf5af66bd_de25750520e744659ca4d7a3947b0a6f command)
		{
		}

		private void BakeCommandBinding__66ffafd329bbe1b47b4184bcf5af66bd_1fb69705e0e4410890417edb7ecacf03(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__66ffafd329bbe1b47b4184bcf5af66bd_1fb69705e0e4410890417edb7ecacf03(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__66ffafd329bbe1b47b4184bcf5af66bd_1fb69705e0e4410890417edb7ecacf03(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__66ffafd329bbe1b47b4184bcf5af66bd_1fb69705e0e4410890417edb7ecacf03(_66ffafd329bbe1b47b4184bcf5af66bd_1fb69705e0e4410890417edb7ecacf03 command)
		{
		}

		private void BakeCommandBinding__66ffafd329bbe1b47b4184bcf5af66bd_133fb2d3f0eb4a459684ef3b584a8172(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__66ffafd329bbe1b47b4184bcf5af66bd_133fb2d3f0eb4a459684ef3b584a8172(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__66ffafd329bbe1b47b4184bcf5af66bd_133fb2d3f0eb4a459684ef3b584a8172(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__66ffafd329bbe1b47b4184bcf5af66bd_133fb2d3f0eb4a459684ef3b584a8172(_66ffafd329bbe1b47b4184bcf5af66bd_133fb2d3f0eb4a459684ef3b584a8172 command)
		{
		}

		private void BakeCommandBinding__66ffafd329bbe1b47b4184bcf5af66bd_8fe08dd0aa284e209cc5e7c83465625b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__66ffafd329bbe1b47b4184bcf5af66bd_8fe08dd0aa284e209cc5e7c83465625b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__66ffafd329bbe1b47b4184bcf5af66bd_8fe08dd0aa284e209cc5e7c83465625b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__66ffafd329bbe1b47b4184bcf5af66bd_8fe08dd0aa284e209cc5e7c83465625b(_66ffafd329bbe1b47b4184bcf5af66bd_8fe08dd0aa284e209cc5e7c83465625b command)
		{
		}

		private void BakeCommandBinding__66ffafd329bbe1b47b4184bcf5af66bd_b1d563b0ad014103b08044284d089113(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__66ffafd329bbe1b47b4184bcf5af66bd_b1d563b0ad014103b08044284d089113(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__66ffafd329bbe1b47b4184bcf5af66bd_b1d563b0ad014103b08044284d089113(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__66ffafd329bbe1b47b4184bcf5af66bd_b1d563b0ad014103b08044284d089113(_66ffafd329bbe1b47b4184bcf5af66bd_b1d563b0ad014103b08044284d089113 command)
		{
		}

		private void BakeCommandBinding__66ffafd329bbe1b47b4184bcf5af66bd_3bd31cc407664f1b846f1edd7863228e(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__66ffafd329bbe1b47b4184bcf5af66bd_3bd31cc407664f1b846f1edd7863228e(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__66ffafd329bbe1b47b4184bcf5af66bd_3bd31cc407664f1b846f1edd7863228e(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__66ffafd329bbe1b47b4184bcf5af66bd_3bd31cc407664f1b846f1edd7863228e(_66ffafd329bbe1b47b4184bcf5af66bd_3bd31cc407664f1b846f1edd7863228e command)
		{
		}

		private void BakeCommandBinding__66ffafd329bbe1b47b4184bcf5af66bd_6c702309f3194b8bb19f1f794dafe094(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__66ffafd329bbe1b47b4184bcf5af66bd_6c702309f3194b8bb19f1f794dafe094(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__66ffafd329bbe1b47b4184bcf5af66bd_6c702309f3194b8bb19f1f794dafe094(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__66ffafd329bbe1b47b4184bcf5af66bd_6c702309f3194b8bb19f1f794dafe094(_66ffafd329bbe1b47b4184bcf5af66bd_6c702309f3194b8bb19f1f794dafe094 command)
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
