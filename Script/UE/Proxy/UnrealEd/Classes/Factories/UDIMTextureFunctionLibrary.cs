using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.UDIMTextureFunctionLibrary")]
	public partial class UUDIMTextureFunctionLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.UDIMTextureFunctionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="OutputPathName">
		/// Path name of the UDIM texture (e.g. /Game/MyTexture)
		/// </param>
		/// <param name="SourceTextures">
		/// List of regular 2D textures to be packed into the atlas
		/// </param>
		/// <param name="BlockCoords">
		/// Coordinates of the corresponding texture in the atlas
		/// </param>
		/// <param name="bKeepExistingSettings">
		/// Whether to keep existing settings if a texture with the same path name exists. Otherwise, settings will be copied from the first source texture
		/// </param>
		/// <param name="bCheckOutAndSave">
		/// Whether to check out and save the UDIM texture
		/// </param>
		/// <returns>
		/// UTexture2D*			Pointer to the UDIM texture or null if failed
		/// </returns>
		public static UTexture2D MakeUDIMVirtualTextureFromTexture2Ds(FString OutputPathName, TArray<UTexture2D> SourceTextures, TArray<FIntPoint> BlockCoords, bool bKeepExistingSettings = false, bool bCheckOutAndSave = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = OutputPathName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SourceTextures?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BlockCoords?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bKeepExistingSettings;

				*(bool*)(__InBuffer + 25) = bCheckOutAndSave;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeUDIMVirtualTextureFromTexture2Ds, __InBuffer, __ReturnBuffer);

				return *(UTexture2D*)__ReturnBuffer;
			}
		}

		private static uint __MakeUDIMVirtualTextureFromTexture2Ds = 0;
	}
}