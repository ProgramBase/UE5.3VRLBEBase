using Script.CoreUObject;
using Script.Library;

namespace Script.ModelingToolsEditorMode
{
	[PathName("/Script/ModelingToolsEditorMode.PathSelectionInteraction")]
	public partial class UPathSelectionInteraction : UObject, IStaticClass
	{
		public TWeakObjectPtr<UModelingSelectionInteraction> SelectionInteraction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SelectionInteraction, __ReturnBuffer);

					return *(TWeakObjectPtr<UModelingSelectionInteraction>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SelectionInteraction, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingToolsEditorMode.PathSelectionInteraction");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SelectionInteraction = 0;
	}
}