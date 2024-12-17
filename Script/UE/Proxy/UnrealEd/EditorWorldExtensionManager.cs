using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EditorWorldExtensionManager")]
	public partial class UEditorWorldExtensionManager : UObject, IStaticClass
	{
		public TArray<UEditorWorldExtensionCollection> EditorWorldExtensionCollection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditorWorldExtensionCollection, __ReturnBuffer);

					return *(TArray<UEditorWorldExtensionCollection>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditorWorldExtensionCollection, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.EditorWorldExtensionManager");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EditorWorldExtensionCollection = 0;
	}
}