using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Engine;
using Script.Library;

namespace Script.MeshPaintingToolset
{
	[PathName("/Script/MeshPaintingToolset.MeshPaintSelectionMechanic")]
	public partial class UMeshPaintSelectionMechanic : UInteractionMechanic, IStaticClass
	{
		public TArray<UMeshComponent> CachedClickedComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedClickedComponents, __ReturnBuffer);

					return *(TArray<UMeshComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedClickedComponents, __InBuffer);
				}
			}
		}

		public TArray<AActor> CachedClickedActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedClickedActors, __ReturnBuffer);

					return *(TArray<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedClickedActors, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshPaintingToolset.MeshPaintSelectionMechanic");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CachedClickedComponents = 0;

		private static uint __CachedClickedActors = 0;
	}
}