using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.PatchVersionAssetDiff")]
	public partial class FPatchVersionAssetDiff : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.PatchVersionAssetDiff");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPatchVersionAssetDiff() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPatchVersionAssetDiff() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPatchVersionAssetDiff A, FPatchVersionAssetDiff B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPatchVersionAssetDiff A, FPatchVersionAssetDiff B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPatchVersionAssetDiff;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FAssetDependenciesInfo AddAssetDependInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AddAssetDependInfo, __ReturnBuffer);

					return *(FAssetDependenciesInfo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AddAssetDependInfo, __InBuffer);
				}
			}
		}

		public FAssetDependenciesInfo ModifyAssetDependInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ModifyAssetDependInfo, __ReturnBuffer);

					return *(FAssetDependenciesInfo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ModifyAssetDependInfo, __InBuffer);
				}
			}
		}

		public FAssetDependenciesInfo DeleteAssetDependInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DeleteAssetDependInfo, __ReturnBuffer);

					return *(FAssetDependenciesInfo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DeleteAssetDependInfo, __InBuffer);
				}
			}
		}

		private static uint __AddAssetDependInfo = 0;

		private static uint __ModifyAssetDependInfo = 0;

		private static uint __DeleteAssetDependInfo = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}