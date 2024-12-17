using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.SkeletalMeshGizmoWrapperBase")]
	public partial class USkeletalMeshGizmoWrapperBase : UObject, IStaticClass
	{
		public TWeakObjectPtr<USceneComponent> Component
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Component, __ReturnBuffer);

					return *(TWeakObjectPtr<USceneComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Component, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.SkeletalMeshGizmoWrapperBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Component = 0;
	}
}