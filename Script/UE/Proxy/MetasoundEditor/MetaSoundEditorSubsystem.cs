using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;
using Script.MetasoundEngine;
using Script.Engine;
using Script.MetasoundFrontend;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetaSoundEditorSubsystem")]
	public partial class UMetaSoundEditorSubsystem : UEditorSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MetasoundEditor.MetaSoundEditorSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetNodeLocation(UMetaSoundBuilderBase InBuilder, FMetaSoundNodeHandle InNode, FVector2D InLocation, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = InBuilder?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __SetNodeLocation, __InBuffer, __OutBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

			}
		}

		/// <param name="Author">
		/// - Sets the author on the given builder's document.
		/// </param>
		/// <param name="AssetName">
		/// - Name of the asset to build.
		/// </param>
		/// <param name="PackagePath">
		/// - Path of package to build asset to.
		/// </param>
		/// <param name="TemplateSoundWave">
		/// - SoundWave settings such as attenuation, modulation, and sound class will be copied from the optional TemplateSoundWave.
		/// </param>
		public virtual TScriptInterface<IMetaSoundDocumentInterface> BuildToAsset(UMetaSoundBuilderBase InBuilder, FString Author, FString AssetName, FString PackagePath, ref EMetaSoundBuilderResult OutResult, USoundWave TemplateSoundWave)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = InBuilder?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Author?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = AssetName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = PackagePath?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 32) = (byte)OutResult;

				*(nint*)(__InBuffer + 33) = TemplateSoundWave?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __BuildToAsset, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(TScriptInterface<IMetaSoundDocumentInterface>*)__ReturnBuffer;
			}
		}

		private static uint __SetNodeLocation = 0;

		private static uint __BuildToAsset = 0;
	}
}