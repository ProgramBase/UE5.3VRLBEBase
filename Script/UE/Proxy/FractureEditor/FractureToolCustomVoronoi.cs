using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolCustomVoronoi")]
	public partial class UFractureToolCustomVoronoi : UFractureToolVoronoiCutterBase, IStaticClass
	{
		public UFractureCustomVoronoiSettings CustomVoronoiSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CustomVoronoiSettings, __ReturnBuffer);

					return *(UFractureCustomVoronoiSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CustomVoronoiSettings, __InBuffer);
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

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolCustomVoronoi");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CustomVoronoiSettings = 0;

		private static uint __GizmoSettings = 0;
	}
}