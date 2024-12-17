using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.ClickDragInputBehavior")]
	public partial class UClickDragInputBehavior : UAnyButtonInputBehavior, IStaticClass
	{
		public bool bUpdateModifiersDuringDrag
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateModifiersDuringDrag, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateModifiersDuringDrag, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.ClickDragInputBehavior");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bUpdateModifiersDuringDrag = 0;
	}
}