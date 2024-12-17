using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;

namespace Script.EditorFramework
{
	[PathName("/Script/EditorFramework.PlacementSubsystem")]
	public partial class UPlacementSubsystem : UEditorSubsystem, IStaticClass
	{
		public TArray<TScriptInterface<IAssetFactoryInterface>> AssetFactories
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssetFactories, __ReturnBuffer);

					return *(TArray<TScriptInterface<IAssetFactoryInterface>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssetFactories, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorFramework.PlacementSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AssetFactories = 0;
	}
}