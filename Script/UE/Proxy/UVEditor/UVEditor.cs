using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.UVEditor
{
	[PathName("/Script/UVEditor.UVEditor")]
	public partial class UUVEditor : UAssetEditor, IStaticClass
	{
		public TArray<UObject> OriginalObjectsToEdit
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OriginalObjectsToEdit, __ReturnBuffer);

					return *(TArray<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OriginalObjectsToEdit, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditor.UVEditor");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __OriginalObjectsToEdit = 0;
	}
}