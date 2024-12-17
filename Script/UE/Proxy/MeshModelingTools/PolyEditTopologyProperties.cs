using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.PolyEditTopologyProperties")]
	public partial class UPolyEditTopologyProperties : UEditMeshPolygonsToolActionPropertySet, IStaticClass
	{
		public bool bAddExtraCorners
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAddExtraCorners, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAddExtraCorners, __InBuffer);
				}
			}
		}

		public double ExtraCornerAngleThresholdDegrees
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExtraCornerAngleThresholdDegrees, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExtraCornerAngleThresholdDegrees, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.PolyEditTopologyProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void RegenerateExtraCorners()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RegenerateExtraCorners);
			}
		}

		private static uint __bAddExtraCorners = 0;

		private static uint __ExtraCornerAngleThresholdDegrees = 0;

		private static uint __RegenerateExtraCorners = 0;
	}
}