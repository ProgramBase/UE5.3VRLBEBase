using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.PackageTools")]
	public partial class UPackageTools : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.PackageTools");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FString SanitizePackageName(FString InPackageName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPackageName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SanitizePackageName, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="PackageName">
		/// Long Package Name
		/// </param>
		/// <param name="Extension">
		/// Package extension.
		/// </param>
		/// <returns>
		/// Package filename, or empty if it failed.
		/// </returns>
		public static FString PackageNameToFilename(FString PackageName, FString Extension = null)
		{
			unsafe
			{
				Extension ??= new FString("");

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PackageName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Extension?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __PackageNameToFilename, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="Filename">
		/// Filename to convert.
		/// </param>
		/// <returns>
		/// Resulting long package name if the supplied filename properly maps to a long package root, empty string otherwise.
		/// </returns>
		public static FString FilenameToPackageName(FString Filename)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Filename?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FilenameToPackageName, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		private static uint __SanitizePackageName = 0;

		private static uint __PackageNameToFilename = 0;

		private static uint __FilenameToPackageName = 0;
	}
}