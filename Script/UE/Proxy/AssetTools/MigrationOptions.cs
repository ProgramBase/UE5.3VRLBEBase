using Script.CoreUObject;
using Script.Library;

namespace Script.AssetTools
{
	[PathName("/Script/AssetTools.MigrationOptions")]
	public partial class FMigrationOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AssetTools.MigrationOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMigrationOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMigrationOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMigrationOptions A, FMigrationOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMigrationOptions A, FMigrationOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMigrationOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EAssetMigrationConflict AssetConflict
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AssetConflict, __ReturnBuffer);

					return *(EAssetMigrationConflict*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AssetConflict, __InBuffer);
				}
			}
		}

		public FString OrphanFolder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OrphanFolder, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OrphanFolder, __InBuffer);
				}
			}
		}

		private static uint __AssetConflict = 0;

		private static uint __OrphanFolder = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}