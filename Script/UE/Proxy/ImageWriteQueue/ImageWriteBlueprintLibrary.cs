using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ImageWriteQueue
{
	[PathName("/Script/ImageWriteQueue.ImageWriteBlueprintLibrary")]
	public partial class UImageWriteBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ImageWriteQueue.ImageWriteBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Texture">
		/// The texture or render target to export
		/// </param>
		/// <param name="Filename">
		/// The filename on disk to save as
		/// </param>
		/// <param name="Options">
		/// Parameters defining the various export options
		/// </param>
		public static void ExportToDisk(UTexture Texture, FString Filename, FImageWriteOptions Options)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Texture?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Filename?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Options?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ExportToDisk, __InBuffer);
			}
		}

		private static uint __ExportToDisk = 0;
	}
}