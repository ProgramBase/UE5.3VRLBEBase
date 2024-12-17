using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.GLTFExporter
{
	[PathName("/Script/GLTFExporter.GLTFExporter")]
	public partial class UGLTFExporter : UExporter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GLTFExporter.GLTFExporter");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Object">
		/// The object to export (supported types are UMaterialInterface, UStaticMesh, USkeletalMesh, UWorld, UAnimSequence, ULevelSequence, ULevelVariantSets). Will default to the currently active world if null.
		/// </param>
		/// <param name="FilePath">
		/// The filename on disk to save as. Associated textures and binary files will be saved in the same folder, unless file extension is .glb - which results in a self-contained binary file.
		/// </param>
		/// <param name="Options">
		/// The various options to use during export. Will default to the project's user-specific editor settings if null.
		/// </param>
		/// <param name="SelectedActors">
		/// The set of actors to export, only applicable if the object to export is a UWorld. An empty set results in the export of all actors.
		/// </param>
		/// <param name="OutMessages">
		/// The resulting log messages from the export.
		/// </param>
		/// <returns>
		/// true if the object was successfully exported
		/// </returns>
		public static bool ExportToGLTF(UObject Object, FString FilePath, UGLTFExportOptions Options, TSet<AActor> SelectedActors, ref FGLTFExportMessages OutMessages)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FilePath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Options?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = SelectedActors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = OutMessages?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __ExportToGLTF, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutMessages = *(FGLTFExportMessages*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __ExportToGLTF = 0;
	}
}