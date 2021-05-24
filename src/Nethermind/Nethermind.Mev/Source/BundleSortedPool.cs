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
// 

using System.Collections.Generic;
using Nethermind.Core;
using Nethermind.Logging;
using Nethermind.Mev.Data;
using Nethermind.TxPool.Collections;

namespace Nethermind.Mev.Source
{
    public class BundleSortedPool : DistinctValueSortedPool<MevBundle, MevBundle, long> 
    {
        public BundleSortedPool(int capacity, IComparer<MevBundle> comparer, ILogManager logManager)
            : base(capacity, comparer, EqualityComparer<MevBundle>.Default, logManager) //why do we need these?
        {
            
        }

        protected override IComparer<MevBundle> GetUniqueComparer(IComparer<MevBundle> comparer) //compares all the bundles to evict the worst one
            => comparer.ThenBy(CompareMevBundlesByIdentity.Default);

        protected override IComparer<MevBundle> GetGroupComparer(IComparer<MevBundle> comparer) //compares two bundles with same block #
            => comparer;

        protected override IComparer<MevBundle> GetSameIdentityComparer(IComparer<MevBundle> comparer) => 
            CompareMevBundlesByPoolIndex.Default;

        protected override long MapToGroup(MevBundle value) => value.BlockNumber;
    }
}