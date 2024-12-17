﻿using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.WeakObjectNetSerializerConfig")]
	public partial class FWeakObjectNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.WeakObjectNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWeakObjectNetSerializerConfig()
		{
		}

		public static bool operator ==(FWeakObjectNetSerializerConfig A, FWeakObjectNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWeakObjectNetSerializerConfig A, FWeakObjectNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWeakObjectNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}