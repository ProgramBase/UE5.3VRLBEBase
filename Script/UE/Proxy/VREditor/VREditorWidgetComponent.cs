using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.VREditor
{
	[PathName("/Script/VREditor.VREditorWidgetComponent")]
	public partial class UVREditorWidgetComponent : UWidgetComponent, IStaticClass
	{
		public EVREditorWidgetDrawingPolicy DrawingPolicy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DrawingPolicy, __ReturnBuffer);

					return *(EVREditorWidgetDrawingPolicy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DrawingPolicy, __InBuffer);
				}
			}
		}

		public bool bIsHovering
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsHovering, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsHovering, __InBuffer);
				}
			}
		}

		public bool bHasEverDrawn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHasEverDrawn, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHasEverDrawn, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VREditor.VREditorWidgetComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DrawingPolicy = 0;

		private static uint __bIsHovering = 0;

		private static uint __bHasEverDrawn = 0;
	}
}