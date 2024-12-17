using Script.CoreUObject;
using Script.Library;

namespace Script.MegascansPlugin
{
	[PathName("/Script/MegascansPlugin.AssetImportTime")]
	public partial class FAssetImportTime : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MegascansPlugin.AssetImportTime");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAssetImportTime() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAssetImportTime() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAssetImportTime A, FAssetImportTime B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAssetImportTime A, FAssetImportTime B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAssetImportTime;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString path
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __path, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __path, __InBuffer);
				}
			}
		}

		public FString time
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __time, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __time, __InBuffer);
				}
			}
		}

		private static uint __path = 0;

		private static uint __time = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}