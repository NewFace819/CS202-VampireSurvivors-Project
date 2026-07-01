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
	public class CoherenceSync_1769df35e8abae9479d0016342154440 : CoherenceSyncBaked
	{
		private Entity entityId;

		private Logger logger;

		private NetworkPickup _1769df35e8abae9479d0016342154440_43b8a3b2c78c477ab06a73411471957a_CommandTarget;

		private NetworkPickup _1769df35e8abae9479d0016342154440_a9134c9b0d9740648574c152695be416_CommandTarget;

		private NetworkPickup _1769df35e8abae9479d0016342154440_2d6c8943581c4754a78ba0789e234c6f_CommandTarget;

		private NetworkPickup _1769df35e8abae9479d0016342154440_fcf669d901f74545a6406d34688752dc_CommandTarget;

		private NetworkPickup _1769df35e8abae9479d0016342154440_446c84b65057481cba26fa5642c7cc05_CommandTarget;

		private NetworkPickup _1769df35e8abae9479d0016342154440_ffc75d59598a466b8906ac1249bcb492_CommandTarget;

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

		private void BakeCommandBinding__1769df35e8abae9479d0016342154440_43b8a3b2c78c477ab06a73411471957a(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1769df35e8abae9479d0016342154440_43b8a3b2c78c477ab06a73411471957a(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1769df35e8abae9479d0016342154440_43b8a3b2c78c477ab06a73411471957a(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1769df35e8abae9479d0016342154440_43b8a3b2c78c477ab06a73411471957a(_1769df35e8abae9479d0016342154440_43b8a3b2c78c477ab06a73411471957a command)
		{
		}

		private void BakeCommandBinding__1769df35e8abae9479d0016342154440_a9134c9b0d9740648574c152695be416(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1769df35e8abae9479d0016342154440_a9134c9b0d9740648574c152695be416(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1769df35e8abae9479d0016342154440_a9134c9b0d9740648574c152695be416(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1769df35e8abae9479d0016342154440_a9134c9b0d9740648574c152695be416(_1769df35e8abae9479d0016342154440_a9134c9b0d9740648574c152695be416 command)
		{
		}

		private void BakeCommandBinding__1769df35e8abae9479d0016342154440_2d6c8943581c4754a78ba0789e234c6f(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1769df35e8abae9479d0016342154440_2d6c8943581c4754a78ba0789e234c6f(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1769df35e8abae9479d0016342154440_2d6c8943581c4754a78ba0789e234c6f(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1769df35e8abae9479d0016342154440_2d6c8943581c4754a78ba0789e234c6f(_1769df35e8abae9479d0016342154440_2d6c8943581c4754a78ba0789e234c6f command)
		{
		}

		private void BakeCommandBinding__1769df35e8abae9479d0016342154440_fcf669d901f74545a6406d34688752dc(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1769df35e8abae9479d0016342154440_fcf669d901f74545a6406d34688752dc(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1769df35e8abae9479d0016342154440_fcf669d901f74545a6406d34688752dc(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1769df35e8abae9479d0016342154440_fcf669d901f74545a6406d34688752dc(_1769df35e8abae9479d0016342154440_fcf669d901f74545a6406d34688752dc command)
		{
		}

		private void BakeCommandBinding__1769df35e8abae9479d0016342154440_446c84b65057481cba26fa5642c7cc05(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1769df35e8abae9479d0016342154440_446c84b65057481cba26fa5642c7cc05(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1769df35e8abae9479d0016342154440_446c84b65057481cba26fa5642c7cc05(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1769df35e8abae9479d0016342154440_446c84b65057481cba26fa5642c7cc05(_1769df35e8abae9479d0016342154440_446c84b65057481cba26fa5642c7cc05 command)
		{
		}

		private void BakeCommandBinding__1769df35e8abae9479d0016342154440_ffc75d59598a466b8906ac1249bcb492(CommandBinding commandBinding, CommandsHandler commandsHandler)
		{
		}

		private void SendCommand__1769df35e8abae9479d0016342154440_ffc75d59598a466b8906ac1249bcb492(MessageTarget target, ChannelID channelID, object[] args)
		{
		}

		private void ReceiveLocalCommand__1769df35e8abae9479d0016342154440_ffc75d59598a466b8906ac1249bcb492(MessageTarget target, ChannelID _, object[] args)
		{
		}

		private void ReceiveCommand__1769df35e8abae9479d0016342154440_ffc75d59598a466b8906ac1249bcb492(_1769df35e8abae9479d0016342154440_ffc75d59598a466b8906ac1249bcb492 command)
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
