﻿using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.BoolNetSerializerConfig")]
	public partial class FBoolNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.BoolNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBoolNetSerializerConfig()
		{
		}

		public static bool operator ==(FBoolNetSerializerConfig A, FBoolNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBoolNetSerializerConfig A, FBoolNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBoolNetSerializerConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}