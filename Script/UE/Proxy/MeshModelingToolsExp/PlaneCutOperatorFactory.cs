using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.PlaneCutOperatorFactory")]
	public partial class UPlaneCutOperatorFactory : UObject, IStaticClass
	{
		public UPlaneCutTool CutTool
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CutTool, __ReturnBuffer);

					return *(UPlaneCutTool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CutTool, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.PlaneCutOperatorFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CutTool = 0;
	}
}