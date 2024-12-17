using Script.CoreUObject;
using Script.Library;

namespace Script.EditorInteractiveToolsFramework
{
	[PathName("/Script/EditorInteractiveToolsFramework.EdModeInteractiveToolsContext")]
	public partial class UEdModeInteractiveToolsContext : UEditorInteractiveToolsContext, IStaticClass
	{
		public UModeManagerInteractiveToolsContext ParentModeManagerToolsContext
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ParentModeManagerToolsContext, __ReturnBuffer);

					return *(UModeManagerInteractiveToolsContext*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ParentModeManagerToolsContext, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorInteractiveToolsFramework.EdModeInteractiveToolsContext");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ParentModeManagerToolsContext = 0;
	}
}