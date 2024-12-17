using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.EditorInteractiveToolsFramework
{
	[PathName("/Script/EditorInteractiveToolsFramework.EditorInteractiveGizmoManager")]
	public partial class UEditorInteractiveGizmoManager : UInteractiveGizmoManager, IStaticClass
	{
		public UEditorInteractiveGizmoRegistry Registry
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Registry, __ReturnBuffer);

					return *(UEditorInteractiveGizmoRegistry*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Registry, __InBuffer);
				}
			}
		}

		public TArray<FActiveEditorGizmo> ActiveEditorGizmos
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveEditorGizmos, __ReturnBuffer);

					return *(TArray<FActiveEditorGizmo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveEditorGizmos, __InBuffer);
				}
			}
		}

		public TMap<UInteractiveGizmoBuilder, UInteractiveGizmo> CachedGizmoMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedGizmoMap, __ReturnBuffer);

					return *(TMap<UInteractiveGizmoBuilder, UInteractiveGizmo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedGizmoMap, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorInteractiveToolsFramework.EditorInteractiveGizmoManager");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Registry = 0;

		private static uint __ActiveEditorGizmos = 0;

		private static uint __CachedGizmoMap = 0;
	}
}