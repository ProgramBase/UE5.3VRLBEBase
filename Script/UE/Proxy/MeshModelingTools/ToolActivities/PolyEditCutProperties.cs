using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.PolyEditCutProperties")]
	public partial class UPolyEditCutProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public EPolyEditCutPlaneOrientation Orientation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Orientation, __ReturnBuffer);

					return *(EPolyEditCutPlaneOrientation*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Orientation, __InBuffer);
				}
			}
		}

		public bool bSnapToVertices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSnapToVertices, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSnapToVertices, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.PolyEditCutProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Orientation = 0;

		private static uint __bSnapToVertices = 0;
	}
}