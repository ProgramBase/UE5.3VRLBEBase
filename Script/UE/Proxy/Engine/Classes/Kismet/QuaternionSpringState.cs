﻿using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.QuaternionSpringState")]
	public partial class FQuaternionSpringState : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.QuaternionSpringState");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FQuaternionSpringState() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FQuaternionSpringState() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FQuaternionSpringState A, FQuaternionSpringState B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FQuaternionSpringState A, FQuaternionSpringState B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FQuaternionSpringState;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}