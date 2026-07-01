using System;
using System.Collections.Generic;
using Coherence.Entities;
using Coherence.Log;
using Coherence.ProtocolDef;
using Coherence.SimulationFrame;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using UnityEngine.Scripting;
using VampireSurvivors;

namespace Coherence.Generated
{
	[Preserve]
	public class CoherenceSync_d42d8caef0b99ac4ca8bd2f2af06e044 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _d42d8caef0b99ac4ca8bd2f2af06e044_e80d70db51e6476b8a829f39cf782e73_CommandTarget;

		private NetworkPickup _d42d8caef0b99ac4ca8bd2f2af06e044_c14c7b3f656646a68bab7abfde94f45f_CommandTarget;

		private NetworkPickup _d42d8caef0b99ac4ca8bd2f2af06e044_7887f78107bb4f65925b413117b6e092_CommandTarget;

		private NetworkPickup _d42d8caef0b99ac4ca8bd2f2af06e044_a3bb8f4a061b407cb6ec26382e5068e4_CommandTarget;

		private NetworkPickup _d42d8caef0b99ac4ca8bd2f2af06e044_e40ff87aebb348909866bafe486596b3_CommandTarget;

		private NetworkPickup _d42d8caef0b99ac4ca8bd2f2af06e044_b18f9d3dffdc47db8b122f1151da5651_CommandTarget;

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

		private void BakeCommandBinding__d42d8caef0b99ac4ca8bd2f2af06e044_e80d70db51e6476b8a829f39cf782e73(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d42d8caef0b99ac4ca8bd2f2af06e044_e80d70db51e6476b8a829f39cf782e73(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d42d8caef0b99ac4ca8bd2f2af06e044_e80d70db51e6476b8a829f39cf782e73(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d42d8caef0b99ac4ca8bd2f2af06e044_e80d70db51e6476b8a829f39cf782e73(_d42d8caef0b99ac4ca8bd2f2af06e044_e80d70db51e6476b8a829f39cf782e73 command)
		{
		}

		private void BakeCommandBinding__d42d8caef0b99ac4ca8bd2f2af06e044_c14c7b3f656646a68bab7abfde94f45f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d42d8caef0b99ac4ca8bd2f2af06e044_c14c7b3f656646a68bab7abfde94f45f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d42d8caef0b99ac4ca8bd2f2af06e044_c14c7b3f656646a68bab7abfde94f45f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d42d8caef0b99ac4ca8bd2f2af06e044_c14c7b3f656646a68bab7abfde94f45f(_d42d8caef0b99ac4ca8bd2f2af06e044_c14c7b3f656646a68bab7abfde94f45f command)
		{
		}

		private void BakeCommandBinding__d42d8caef0b99ac4ca8bd2f2af06e044_7887f78107bb4f65925b413117b6e092(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d42d8caef0b99ac4ca8bd2f2af06e044_7887f78107bb4f65925b413117b6e092(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d42d8caef0b99ac4ca8bd2f2af06e044_7887f78107bb4f65925b413117b6e092(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d42d8caef0b99ac4ca8bd2f2af06e044_7887f78107bb4f65925b413117b6e092(_d42d8caef0b99ac4ca8bd2f2af06e044_7887f78107bb4f65925b413117b6e092 command)
		{
		}

		private void BakeCommandBinding__d42d8caef0b99ac4ca8bd2f2af06e044_a3bb8f4a061b407cb6ec26382e5068e4(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d42d8caef0b99ac4ca8bd2f2af06e044_a3bb8f4a061b407cb6ec26382e5068e4(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d42d8caef0b99ac4ca8bd2f2af06e044_a3bb8f4a061b407cb6ec26382e5068e4(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d42d8caef0b99ac4ca8bd2f2af06e044_a3bb8f4a061b407cb6ec26382e5068e4(_d42d8caef0b99ac4ca8bd2f2af06e044_a3bb8f4a061b407cb6ec26382e5068e4 command)
		{
		}

		private void BakeCommandBinding__d42d8caef0b99ac4ca8bd2f2af06e044_e40ff87aebb348909866bafe486596b3(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d42d8caef0b99ac4ca8bd2f2af06e044_e40ff87aebb348909866bafe486596b3(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d42d8caef0b99ac4ca8bd2f2af06e044_e40ff87aebb348909866bafe486596b3(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d42d8caef0b99ac4ca8bd2f2af06e044_e40ff87aebb348909866bafe486596b3(_d42d8caef0b99ac4ca8bd2f2af06e044_e40ff87aebb348909866bafe486596b3 command)
		{
		}

		private void BakeCommandBinding__d42d8caef0b99ac4ca8bd2f2af06e044_b18f9d3dffdc47db8b122f1151da5651(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__d42d8caef0b99ac4ca8bd2f2af06e044_b18f9d3dffdc47db8b122f1151da5651(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__d42d8caef0b99ac4ca8bd2f2af06e044_b18f9d3dffdc47db8b122f1151da5651(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__d42d8caef0b99ac4ca8bd2f2af06e044_b18f9d3dffdc47db8b122f1151da5651(_d42d8caef0b99ac4ca8bd2f2af06e044_b18f9d3dffdc47db8b122f1151da5651 command)
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
