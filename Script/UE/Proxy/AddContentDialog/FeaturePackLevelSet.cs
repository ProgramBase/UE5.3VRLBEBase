using Script.CoreUObject;
using Script.Library;

namespace Script.AddContentDialog
{
	[PathName("/Script/AddContentDialog.FeaturePackLevelSet")]
	public partial class FFeaturePackLevelSet : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AddContentDialog.FeaturePackLevelSet");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFeaturePackLevelSet() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFeaturePackLevelSet() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFeaturePackLevelSet A, FFeaturePackLevelSet B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFeaturePackLevelSet A, FFeaturePackLevelSet B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFeaturePackLevelSet;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<EFeaturePackDetailLevel> DetailLevels
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DetailLevels, __ReturnBuffer);

					return *(TArray<EFeaturePackDetailLevel>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DetailLevels, __InBuffer);
				}
			}
		}

		public FString MountName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MountName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MountName, __InBuffer);
				}
			}
		}

		private static uint __DetailLevels = 0;

		private static uint __MountName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}