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
	public class CoherenceSync_0872fdc53ff04e8479039324cb1f0008 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private CharacterController _0872fdc53ff04e8479039324cb1f0008_5b849c362e234f8e84a32f38ab70f006_CommandTarget;

		private CharacterController _0872fdc53ff04e8479039324cb1f0008_946862d9ffdb4ababe94c207f03e1d5b_CommandTarget;

		private CharacterController _0872fdc53ff04e8479039324cb1f0008_bbe7a0d160b94af687d7bff3996d259f_CommandTarget;

		private CharacterController _0872fdc53ff04e8479039324cb1f0008_26dc979f12cf4e0fa55704600c8d3145_CommandTarget;

		private CharacterController _0872fdc53ff04e8479039324cb1f0008_2a8988bc65224304a55050070527d2c6_CommandTarget;

		private CharacterController _0872fdc53ff04e8479039324cb1f0008_e3aa4471fab64b70b96c748639180d08_CommandTarget;

		private CharacterController _0872fdc53ff04e8479039324cb1f0008_1e8e4aa5eb814636805369cdb5bbcd9b_CommandTarget;

		private CharacterController _0872fdc53ff04e8479039324cb1f0008_990d00316a394e15871aad0f23a36b1c_CommandTarget;

		private CharacterController _0872fdc53ff04e8479039324cb1f0008_8a64a556b59d46fd99294126c7f4258d_CommandTarget;

		private CharacterController _0872fdc53ff04e8479039324cb1f0008_7576f459b784439ab709950c53e7e930_CommandTarget;

		private CharacterController _0872fdc53ff04e8479039324cb1f0008_bfb4ddb4043041bf971d7dce0864bf4d_CommandTarget;

		private CharacterController _0872fdc53ff04e8479039324cb1f0008_4b0a70c1820845a98ea4731ea283e217_CommandTarget;

		private CharacterController _0872fdc53ff04e8479039324cb1f0008_4aca45fb74cd46c18870e63e59b3705b_CommandTarget;

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

		private void BakeCommandBinding__0872fdc53ff04e8479039324cb1f0008_5b849c362e234f8e84a32f38ab70f006(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0872fdc53ff04e8479039324cb1f0008_5b849c362e234f8e84a32f38ab70f006(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0872fdc53ff04e8479039324cb1f0008_5b849c362e234f8e84a32f38ab70f006(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0872fdc53ff04e8479039324cb1f0008_5b849c362e234f8e84a32f38ab70f006(_0872fdc53ff04e8479039324cb1f0008_5b849c362e234f8e84a32f38ab70f006 command)
		{
		}

		private void BakeCommandBinding__0872fdc53ff04e8479039324cb1f0008_946862d9ffdb4ababe94c207f03e1d5b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0872fdc53ff04e8479039324cb1f0008_946862d9ffdb4ababe94c207f03e1d5b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0872fdc53ff04e8479039324cb1f0008_946862d9ffdb4ababe94c207f03e1d5b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0872fdc53ff04e8479039324cb1f0008_946862d9ffdb4ababe94c207f03e1d5b(_0872fdc53ff04e8479039324cb1f0008_946862d9ffdb4ababe94c207f03e1d5b command)
		{
		}

		private void BakeCommandBinding__0872fdc53ff04e8479039324cb1f0008_bbe7a0d160b94af687d7bff3996d259f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0872fdc53ff04e8479039324cb1f0008_bbe7a0d160b94af687d7bff3996d259f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0872fdc53ff04e8479039324cb1f0008_bbe7a0d160b94af687d7bff3996d259f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0872fdc53ff04e8479039324cb1f0008_bbe7a0d160b94af687d7bff3996d259f(_0872fdc53ff04e8479039324cb1f0008_bbe7a0d160b94af687d7bff3996d259f command)
		{
		}

		private void BakeCommandBinding__0872fdc53ff04e8479039324cb1f0008_26dc979f12cf4e0fa55704600c8d3145(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0872fdc53ff04e8479039324cb1f0008_26dc979f12cf4e0fa55704600c8d3145(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0872fdc53ff04e8479039324cb1f0008_26dc979f12cf4e0fa55704600c8d3145(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0872fdc53ff04e8479039324cb1f0008_26dc979f12cf4e0fa55704600c8d3145(_0872fdc53ff04e8479039324cb1f0008_26dc979f12cf4e0fa55704600c8d3145 command)
		{
		}

		private void BakeCommandBinding__0872fdc53ff04e8479039324cb1f0008_2a8988bc65224304a55050070527d2c6(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0872fdc53ff04e8479039324cb1f0008_2a8988bc65224304a55050070527d2c6(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0872fdc53ff04e8479039324cb1f0008_2a8988bc65224304a55050070527d2c6(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0872fdc53ff04e8479039324cb1f0008_2a8988bc65224304a55050070527d2c6(_0872fdc53ff04e8479039324cb1f0008_2a8988bc65224304a55050070527d2c6 command)
		{
		}

		private void BakeCommandBinding__0872fdc53ff04e8479039324cb1f0008_e3aa4471fab64b70b96c748639180d08(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0872fdc53ff04e8479039324cb1f0008_e3aa4471fab64b70b96c748639180d08(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0872fdc53ff04e8479039324cb1f0008_e3aa4471fab64b70b96c748639180d08(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0872fdc53ff04e8479039324cb1f0008_e3aa4471fab64b70b96c748639180d08(_0872fdc53ff04e8479039324cb1f0008_e3aa4471fab64b70b96c748639180d08 command)
		{
		}

		private void BakeCommandBinding__0872fdc53ff04e8479039324cb1f0008_1e8e4aa5eb814636805369cdb5bbcd9b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0872fdc53ff04e8479039324cb1f0008_1e8e4aa5eb814636805369cdb5bbcd9b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0872fdc53ff04e8479039324cb1f0008_1e8e4aa5eb814636805369cdb5bbcd9b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0872fdc53ff04e8479039324cb1f0008_1e8e4aa5eb814636805369cdb5bbcd9b(_0872fdc53ff04e8479039324cb1f0008_1e8e4aa5eb814636805369cdb5bbcd9b command)
		{
		}

		private void BakeCommandBinding__0872fdc53ff04e8479039324cb1f0008_990d00316a394e15871aad0f23a36b1c(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0872fdc53ff04e8479039324cb1f0008_990d00316a394e15871aad0f23a36b1c(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0872fdc53ff04e8479039324cb1f0008_990d00316a394e15871aad0f23a36b1c(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0872fdc53ff04e8479039324cb1f0008_990d00316a394e15871aad0f23a36b1c(_0872fdc53ff04e8479039324cb1f0008_990d00316a394e15871aad0f23a36b1c command)
		{
		}

		private void BakeCommandBinding__0872fdc53ff04e8479039324cb1f0008_8a64a556b59d46fd99294126c7f4258d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0872fdc53ff04e8479039324cb1f0008_8a64a556b59d46fd99294126c7f4258d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0872fdc53ff04e8479039324cb1f0008_8a64a556b59d46fd99294126c7f4258d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0872fdc53ff04e8479039324cb1f0008_8a64a556b59d46fd99294126c7f4258d(_0872fdc53ff04e8479039324cb1f0008_8a64a556b59d46fd99294126c7f4258d command)
		{
		}

		private void BakeCommandBinding__0872fdc53ff04e8479039324cb1f0008_7576f459b784439ab709950c53e7e930(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0872fdc53ff04e8479039324cb1f0008_7576f459b784439ab709950c53e7e930(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0872fdc53ff04e8479039324cb1f0008_7576f459b784439ab709950c53e7e930(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0872fdc53ff04e8479039324cb1f0008_7576f459b784439ab709950c53e7e930(_0872fdc53ff04e8479039324cb1f0008_7576f459b784439ab709950c53e7e930 command)
		{
		}

		private void BakeCommandBinding__0872fdc53ff04e8479039324cb1f0008_bfb4ddb4043041bf971d7dce0864bf4d(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0872fdc53ff04e8479039324cb1f0008_bfb4ddb4043041bf971d7dce0864bf4d(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0872fdc53ff04e8479039324cb1f0008_bfb4ddb4043041bf971d7dce0864bf4d(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0872fdc53ff04e8479039324cb1f0008_bfb4ddb4043041bf971d7dce0864bf4d(_0872fdc53ff04e8479039324cb1f0008_bfb4ddb4043041bf971d7dce0864bf4d command)
		{
		}

		private void BakeCommandBinding__0872fdc53ff04e8479039324cb1f0008_4b0a70c1820845a98ea4731ea283e217(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0872fdc53ff04e8479039324cb1f0008_4b0a70c1820845a98ea4731ea283e217(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0872fdc53ff04e8479039324cb1f0008_4b0a70c1820845a98ea4731ea283e217(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0872fdc53ff04e8479039324cb1f0008_4b0a70c1820845a98ea4731ea283e217(_0872fdc53ff04e8479039324cb1f0008_4b0a70c1820845a98ea4731ea283e217 command)
		{
		}

		private void BakeCommandBinding__0872fdc53ff04e8479039324cb1f0008_4aca45fb74cd46c18870e63e59b3705b(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__0872fdc53ff04e8479039324cb1f0008_4aca45fb74cd46c18870e63e59b3705b(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__0872fdc53ff04e8479039324cb1f0008_4aca45fb74cd46c18870e63e59b3705b(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__0872fdc53ff04e8479039324cb1f0008_4aca45fb74cd46c18870e63e59b3705b(_0872fdc53ff04e8479039324cb1f0008_4aca45fb74cd46c18870e63e59b3705b command)
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
