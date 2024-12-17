using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.UnrealEd.ImportSubsystem;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ImportSubsystem")]
	public partial class UImportSubsystem : UEditorSubsystem, IStaticClass
	{
		public FOnAssetPreImport_Dyn OnAssetPreImport_BP
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnAssetPreImport_BP, __ReturnBuffer);

					return *(FOnAssetPreImport_Dyn*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnAssetPreImport_BP, __InBuffer);
				}
			}
		}

		public FOnAssetPostImport_Dyn OnAssetPostImport_BP
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnAssetPostImport_BP, __ReturnBuffer);

					return *(FOnAssetPostImport_Dyn*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnAssetPostImport_BP, __InBuffer);
				}
			}
		}

		public FOnAssetReimport_Dyn OnAssetReimport_BP
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnAssetReimport_BP, __ReturnBuffer);

					return *(FOnAssetReimport_Dyn*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnAssetReimport_BP, __InBuffer);
				}
			}
		}

		public FOnAssetPostLODImport_Dyn OnAssetPostLODImport_BP
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnAssetPostLODImport_BP, __ReturnBuffer);

					return *(FOnAssetPostLODImport_Dyn*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnAssetPostLODImport_BP, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ImportSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __OnAssetPreImport_BP = 0;

		private static uint __OnAssetPostImport_BP = 0;

		private static uint __OnAssetReimport_BP = 0;

		private static uint __OnAssetPostLODImport_BP = 0;
	}
}