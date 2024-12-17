using Script.CoreUObject;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVTool2DViewportAPI")]
	public partial class UUVTool2DViewportAPI : UUVToolContextObject, IStaticClass
	{
		public TArray<FUDIMBlock> UDIMBlocks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UDIMBlocks, __ReturnBuffer);

					return *(TArray<FUDIMBlock>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UDIMBlocks, __InBuffer);
				}
			}
		}

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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVTool2DViewportAPI");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __UDIMBlocks = 0;

		private static uint __bDrawGrid = 0;

		private static uint __bDrawRulers = 0;
	}
}