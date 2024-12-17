﻿using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.PatherResult")]
	public partial class FPatherResult : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.PatherResult");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPatherResult() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPatherResult() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPatherResult A, FPatherResult B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPatherResult A, FPatherResult B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPatherResult;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FAssetDetail> PatcherAssetDetails
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PatcherAssetDetails, __ReturnBuffer);

					return *(TArray<FAssetDetail>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PatcherAssetDetails, __InBuffer);
				}
			}
		}

		private static uint __PatcherAssetDetails = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}