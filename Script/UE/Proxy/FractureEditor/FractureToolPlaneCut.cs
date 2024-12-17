using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolPlaneCut")]
	public partial class UFractureToolPlaneCut : UFractureToolCutterBase, IStaticClass
	{
		public UFracturePlaneCutSettings PlaneCutSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlaneCutSettings, __ReturnBuffer);

					return *(UFracturePlaneCutSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlaneCutSettings, __InBuffer);
				}
			}
		}

		public UFractureTransformGizmoSettings GizmoSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GizmoSettings, __ReturnBuffer);

					return *(UFractureTransformGizmoSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GizmoSettings, __InBuffer);
				}
			}
		}

		public UMeshOpPreviewWithBackgroundCompute NoisePreview
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NoisePreview, __ReturnBuffer);

					return *(UMeshOpPreviewWithBackgroundCompute*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NoisePreview, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolPlaneCut");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PlaneCutSettings = 0;

		private static uint __GizmoSettings = 0;

		private static uint __NoisePreview = 0;
	}
}