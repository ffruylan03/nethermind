//  Copyright (c) 2021 Demerzel Solutions Limited
//  This file is part of the Nethermind library.
// 
//  The Nethermind library is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  The Nethermind library is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU Lesser General Public License for more details.
// 
//  You should have received a copy of the GNU Lesser General Public License
//  along with the Nethermind. If not, see <http://www.gnu.org/licenses/>.

using System.Threading;
using Nethermind.Blockchain.Find;
using Nethermind.Core;
using Nethermind.Core.Crypto;
using Nethermind.Evm.Tracing.GethStyle;
using Nethermind.Serialization.Rlp;

namespace Nethermind.Consensus.Tracing
{
    public interface IGethStyleTracer
    {
        GethLikeTxTrace Trace(Keccak txHash, GethTraceOptions options, CancellationToken cancellationToken);
        GethLikeTxTrace Trace(long blockNumber, Transaction transaction, GethTraceOptions options, CancellationToken cancellationToken);
        GethLikeTxTrace Trace(long blockNumber, int txIndex, GethTraceOptions options, CancellationToken cancellationToken);
        GethLikeTxTrace Trace(Keccak blockHash, int txIndex, GethTraceOptions options, CancellationToken cancellationToken);
        GethLikeTxTrace Trace(Rlp blockRlp, Keccak txHash, GethTraceOptions options, CancellationToken cancellationToken);
        GethLikeTxTrace? Trace(BlockParameter blockParameter, Transaction tx, GethTraceOptions options, CancellationToken cancellationToken);
        GethLikeTxTrace[] TraceBlock(BlockParameter blockParameter, GethTraceOptions options, CancellationToken cancellationToken);
        GethLikeTxTrace[] TraceBlock(Rlp blockRlp, GethTraceOptions options, CancellationToken cancellationToken);
    }
}
