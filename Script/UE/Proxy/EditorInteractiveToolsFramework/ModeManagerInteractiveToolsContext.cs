using Script.CoreUObject;
using Script.Library;

namespace Script.EditorInteractiveToolsFramework
{
	[PathName("/Script/EditorInteractiveToolsFramework.ModeManagerInteractiveToolsContext")]
	public partial class UModeManagerInteractiveToolsContext : UEditorInteractiveToolsContext, IStaticClass
	{
		public TArray<UEdModeInteractiveToolsContext> EdModeToolsContexts
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EdModeToolsContexts, __ReturnBuffer);

					return *(TArray<UEdModeInteractiveToolsContext>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EdModeToolsContexts, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorInteractiveToolsFramework.ModeManagerInteractiveToolsContext");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EdModeToolsContexts = 0;
	}
}