using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.ViewportDragOperationComponent")]
	public partial class UViewportDragOperationComponent : UActorComponent, IStaticClass
	{
		public UViewportDragOperation DragOperation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DragOperation, __ReturnBuffer);

					return *(UViewportDragOperation*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DragOperation, __InBuffer);
				}
			}
		}

		public TSubclassOf<UViewportDragOperation> DragOperationSubclass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DragOperationSubclass, __ReturnBuffer);

					return *(TSubclassOf<UViewportDragOperation>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DragOperationSubclass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.ViewportDragOperationComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DragOperation = 0;

		private static uint __DragOperationSubclass = 0;
	}
}