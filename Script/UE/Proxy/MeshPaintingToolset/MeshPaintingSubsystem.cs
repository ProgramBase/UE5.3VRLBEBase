using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MeshPaintingToolset
{
	[PathName("/Script/MeshPaintingToolset.MeshPaintingSubsystem")]
	public partial class UMeshPaintingSubsystem : UEngineSubsystem, IStaticClass
	{
		public TWeakObjectPtr<UTexture> OverridePaintTexture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OverridePaintTexture, __ReturnBuffer);

					return *(TWeakObjectPtr<UTexture>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OverridePaintTexture, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshPaintingToolset.MeshPaintingSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __OverridePaintTexture = 0;
	}
}