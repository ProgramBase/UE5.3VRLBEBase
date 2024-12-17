using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.RepositionableTransformGizmo")]
	public partial class URepositionableTransformGizmo : UCombinedTransformGizmo, IStaticClass
	{
		public UGizmoTransformChangeStateTarget RepositionStateTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RepositionStateTarget, __ReturnBuffer);

					return *(UGizmoTransformChangeStateTarget*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RepositionStateTarget, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.RepositionableTransformGizmo");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __RepositionStateTarget = 0;
	}
}