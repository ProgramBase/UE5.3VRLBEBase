using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.AssetEditorToolkitMenuContext")]
	public partial class UAssetEditorToolkitMenuContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.AssetEditorToolkitMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual TArray<UObject> GetEditingObjects()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetEditingObjects, __ReturnBuffer);

				return *(TArray<UObject>*)__ReturnBuffer;
			}
		}

		private static uint __GetEditingObjects = 0;
	}
}