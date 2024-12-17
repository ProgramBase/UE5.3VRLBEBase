﻿using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AIDataProviderStructValue")]
	public partial class FAIDataProviderStructValue : FAIDataProviderValue, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIModule.AIDataProviderStructValue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAIDataProviderStructValue()
		{
		}

		public static bool operator ==(FAIDataProviderStructValue A, FAIDataProviderStructValue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAIDataProviderStructValue A, FAIDataProviderStructValue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAIDataProviderStructValue;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}