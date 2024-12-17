﻿using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.CaptureLostEvent")]
	public partial class FCaptureLostEvent : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SlateCore.CaptureLostEvent");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCaptureLostEvent() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCaptureLostEvent() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCaptureLostEvent A, FCaptureLostEvent B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCaptureLostEvent A, FCaptureLostEvent B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCaptureLostEvent;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}