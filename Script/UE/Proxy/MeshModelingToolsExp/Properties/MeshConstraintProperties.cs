using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.MeshConstraintProperties")]
	public partial class UMeshConstraintProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public bool bPreserveSharpEdges
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPreserveSharpEdges, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPreserveSharpEdges, __InBuffer);
				}
			}
		}

		public EMeshBoundaryConstraint MeshBoundaryConstraint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MeshBoundaryConstraint, __ReturnBuffer);

					return *(EMeshBoundaryConstraint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MeshBoundaryConstraint, __InBuffer);
				}
			}
		}

		public EGroupBoundaryConstraint GroupBoundaryConstraint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GroupBoundaryConstraint, __ReturnBuffer);

					return *(EGroupBoundaryConstraint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GroupBoundaryConstraint, __InBuffer);
				}
			}
		}

		public EMaterialBoundaryConstraint MaterialBoundaryConstraint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialBoundaryConstraint, __ReturnBuffer);

					return *(EMaterialBoundaryConstraint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialBoundaryConstraint, __InBuffer);
				}
			}
		}

		public bool bPreventNormalFlips
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPreventNormalFlips, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPreventNormalFlips, __InBuffer);
				}
			}
		}

		public bool bPreventTinyTriangles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPreventTinyTriangles, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPreventTinyTriangles, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.MeshConstraintProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool IsPreventTinyTrianglesEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsPreventTinyTrianglesEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsPreventNormalFlipsEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsPreventNormalFlipsEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __bPreserveSharpEdges = 0;

		private static uint __MeshBoundaryConstraint = 0;

		private static uint __GroupBoundaryConstraint = 0;

		private static uint __MaterialBoundaryConstraint = 0;

		private static uint __bPreventNormalFlips = 0;

		private static uint __bPreventTinyTriangles = 0;

		private static uint __IsPreventTinyTrianglesEnabled = 0;

		private static uint __IsPreventNormalFlipsEnabled = 0;
	}
}