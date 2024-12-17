using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.SingleClickOrDragInputBehavior")]
	public partial class USingleClickOrDragInputBehavior : UAnyButtonInputBehavior, IStaticClass
	{
		public bool bBeginDragIfClickTargetNotHit
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bBeginDragIfClickTargetNotHit, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bBeginDragIfClickTargetNotHit, __InBuffer);
				}
			}
		}

		public float ClickDistanceThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClickDistanceThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClickDistanceThreshold, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.SingleClickOrDragInputBehavior");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bBeginDragIfClickTargetNotHit = 0;

		private static uint __ClickDistanceThreshold = 0;
	}
}