using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.TopLevelAssetPath")]
	public partial class FTopLevelAssetPath : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.TopLevelAssetPath");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTopLevelAssetPath() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTopLevelAssetPath() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTopLevelAssetPath A, FTopLevelAssetPath B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTopLevelAssetPath A, FTopLevelAssetPath B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTopLevelAssetPath;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName PackageName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PackageName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PackageName, __InBuffer);
				}
			}
		}

		public FName AssetName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AssetName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AssetName, __InBuffer);
				}
			}
		}

		private static uint __PackageName = 0;

		private static uint __AssetName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}