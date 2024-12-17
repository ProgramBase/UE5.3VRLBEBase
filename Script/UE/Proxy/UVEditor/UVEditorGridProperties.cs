using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.UVEditor
{
	[PathName("/Script/UVEditor.UVEditorGridProperties")]
	public partial class UUVEditorGridProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public bool bDrawGrid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDrawGrid, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDrawGrid, __InBuffer);
				}
			}
		}

		public bool bDrawRulers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDrawRulers, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDrawRulers, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditor.UVEditorGridProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bDrawGrid = 0;

		private static uint __bDrawRulers = 0;
	}
}