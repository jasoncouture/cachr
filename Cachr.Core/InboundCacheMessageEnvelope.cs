using Cachr.Core.Buffers;

namespace Cachr.Core;

public record struct InboundCacheMessageEnvelope(Guid Sender, Guid? Target, IDistributedCacheMessage Message);
