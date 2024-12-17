using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.EditorInteractiveToolsFramework
{
	[PathName("/Script/EditorInteractiveToolsFramework.EditorInteractiveGizmoSubsystem")]
	public partial class UEditorInteractiveGizmoSubsystem : UEditorSubsystem, IStaticClass
	{
		public UInteractiveGizmoBuilder TransformGizmoBuilder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TransformGizmoBuilder, __ReturnBuffer);

					return *(UInteractiveGizmoBuilder*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TransformGizmoBuilder, __InBuffer);
				}
			}
		}

		public UEditorInteractiveGizmoRegistry Registry
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Registry, __ReturnBuffer);

					return *(UEditorInteractiveGizmoRegistry*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Registry, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorInteractiveToolsFramework.EditorInteractiveGizmoSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TransformGizmoBuilder = 0;

		private static uint __Registry = 0;
	}
}