using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.DrawPolyPathExtrudeProperties")]
	public partial class UDrawPolyPathExtrudeProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public EDrawPolyPathExtrudeDirection Direction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Direction, __ReturnBuffer);

					return *(EDrawPolyPathExtrudeDirection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Direction, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.DrawPolyPathExtrudeProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Direction = 0;
	}
}