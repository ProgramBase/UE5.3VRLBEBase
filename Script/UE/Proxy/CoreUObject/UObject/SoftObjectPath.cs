using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.SoftObjectPath")]
	public partial class FSoftObjectPath : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.SoftObjectPath");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSoftObjectPath() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSoftObjectPath() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSoftObjectPath A, FSoftObjectPath B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSoftObjectPath A, FSoftObjectPath B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSoftObjectPath;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FTopLevelAssetPath AssetPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AssetPath, __ReturnBuffer);

					return *(FTopLevelAssetPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AssetPath, __InBuffer);
				}
			}
		}

		public FString SubPathString
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SubPathString, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SubPathString, __InBuffer);
				}
			}
		}

		private static uint __AssetPath = 0;

		private static uint __SubPathString = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}