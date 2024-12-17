using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.PrimaryAssetId")]
	public partial class FPrimaryAssetId : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.PrimaryAssetId");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPrimaryAssetId() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPrimaryAssetId() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPrimaryAssetId A, FPrimaryAssetId B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPrimaryAssetId A, FPrimaryAssetId B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPrimaryAssetId;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FPrimaryAssetType PrimaryAssetType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PrimaryAssetType, __ReturnBuffer);

					return *(FPrimaryAssetType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PrimaryAssetType, __InBuffer);
				}
			}
		}

		public FName PrimaryAssetName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PrimaryAssetName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PrimaryAssetName, __InBuffer);
				}
			}
		}

		private static uint __PrimaryAssetType = 0;

		private static uint __PrimaryAssetName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}