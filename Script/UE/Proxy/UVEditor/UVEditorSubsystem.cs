using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.UVEditor
{
	[PathName("/Script/UVEditor.UVEditorSubsystem")]
	public partial class UUVEditorSubsystem : UEditorSubsystem, IStaticClass
	{
		public UToolTargetManager ToolTargetManager
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ToolTargetManager, __ReturnBuffer);

					return *(UToolTargetManager*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ToolTargetManager, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditor.UVEditorSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ToolTargetManager = 0;
	}
}