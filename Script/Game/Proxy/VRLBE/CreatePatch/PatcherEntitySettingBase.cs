﻿using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.PatcherEntitySettingBase")]
	public partial class FPatcherEntitySettingBase : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.PatcherEntitySettingBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPatcherEntitySettingBase() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPatcherEntitySettingBase() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPatcherEntitySettingBase A, FPatcherEntitySettingBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPatcherEntitySettingBase A, FPatcherEntitySettingBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPatcherEntitySettingBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}