using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.BaseKelvinletBrushOpProps")]
	public partial class UBaseKelvinletBrushOpProps : UMeshSculptBrushOpProps, IStaticClass
	{
		public float Stiffness
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Stiffness, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Stiffness, __InBuffer);
				}
			}
		}

		public float Incompressiblity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Incompressiblity, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Incompressiblity, __InBuffer);
				}
			}
		}

		public int BrushSteps
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BrushSteps, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BrushSteps, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.BaseKelvinletBrushOpProps");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Stiffness = 0;

		private static uint __Incompressiblity = 0;

		private static uint __BrushSteps = 0;
	}
}