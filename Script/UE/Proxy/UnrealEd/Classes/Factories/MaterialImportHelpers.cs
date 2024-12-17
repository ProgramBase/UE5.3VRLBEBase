using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MaterialImportHelpers")]
	public partial class UMaterialImportHelpers : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.MaterialImportHelpers");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UMaterialInterface FindExistingMaterialFromSearchLocation(FString MaterialFullName, FString BasePackagePath, EMaterialSearchLocation SearchLocation, ref FText OutError)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = MaterialFullName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BasePackagePath?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)SearchLocation;

				*(nint*)(__InBuffer + 17) = OutError?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __FindExistingMaterialFromSearchLocation, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutError = *(FText*)(__OutBuffer);

				return *(UMaterialInterface*)__ReturnBuffer;
			}
		}

		public static UMaterialInterface FindExistingMaterial(FString BasePath, FString MaterialFullName, bool bRecursivePaths, ref FText OutError)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = BasePath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MaterialFullName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bRecursivePaths;

				*(nint*)(__InBuffer + 17) = OutError?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __FindExistingMaterial, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutError = *(FText*)(__OutBuffer);

				return *(UMaterialInterface*)__ReturnBuffer;
			}
		}

		private static uint __FindExistingMaterialFromSearchLocation = 0;

		private static uint __FindExistingMaterial = 0;
	}
}