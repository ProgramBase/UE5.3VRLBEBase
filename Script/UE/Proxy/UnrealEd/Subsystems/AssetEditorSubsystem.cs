using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;
using Script.AssetTools;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.AssetEditorSubsystem")]
	public partial class UAssetEditorSubsystem : UEditorSubsystem, IStaticClass
	{
		public TArray<UAssetEditor> OwnedAssetEditors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OwnedAssetEditors, __ReturnBuffer);

					return *(TArray<UAssetEditor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OwnedAssetEditors, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.AssetEditorSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool OpenEditorForAssets(TArray<UObject> Assets, EAssetTypeActivationOpenedMethod OpenedMethod = EAssetTypeActivationOpenedMethod.Edit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Assets?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OpenedMethod;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __OpenEditorForAssets, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual int CloseAllEditorsForAsset(UObject Asset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Asset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CloseAllEditorsForAsset, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __OwnedAssetEditors = 0;

		private static uint __OpenEditorForAssets = 0;

		private static uint __CloseAllEditorsForAsset = 0;
	}
}