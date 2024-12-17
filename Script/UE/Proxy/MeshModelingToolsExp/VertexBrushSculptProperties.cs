using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.VertexBrushSculptProperties")]
	public partial class UVertexBrushSculptProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public EMeshVertexSculptBrushType PrimaryBrushType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PrimaryBrushType, __ReturnBuffer);

					return *(EMeshVertexSculptBrushType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PrimaryBrushType, __InBuffer);
				}
			}
		}

		public EMeshSculptFalloffType PrimaryFalloffType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PrimaryFalloffType, __ReturnBuffer);

					return *(EMeshSculptFalloffType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PrimaryFalloffType, __InBuffer);
				}
			}
		}

		public EMeshVertexSculptBrushFilterType BrushFilter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BrushFilter, __ReturnBuffer);

					return *(EMeshVertexSculptBrushFilterType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BrushFilter, __InBuffer);
				}
			}
		}

		public bool bFreezeTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bFreezeTarget, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bFreezeTarget, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UMeshVertexSculptTool> Tool
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Tool, __ReturnBuffer);

					return *(TWeakObjectPtr<UMeshVertexSculptTool>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Tool, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.VertexBrushSculptProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PrimaryBrushType = 0;

		private static uint __PrimaryFalloffType = 0;

		private static uint __BrushFilter = 0;

		private static uint __bFreezeTarget = 0;

		private static uint __Tool = 0;
	}
}