﻿using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.SequencePlayerReference")]
	public partial class FSequencePlayerReference : FAnimNodeReference, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.SequencePlayerReference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSequencePlayerReference()
		{
		}

		public static bool operator ==(FSequencePlayerReference A, FSequencePlayerReference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSequencePlayerReference A, FSequencePlayerReference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSequencePlayerReference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}