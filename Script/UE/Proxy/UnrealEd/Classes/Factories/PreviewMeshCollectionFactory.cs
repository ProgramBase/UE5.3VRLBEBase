using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.PreviewMeshCollectionFactory")]
	public partial class UPreviewMeshCollectionFactory : UFactory, IStaticClass
	{
		public TWeakObjectPtr<USkeleton> CurrentSkeleton
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentSkeleton, __ReturnBuffer);

					return *(TWeakObjectPtr<USkeleton>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentSkeleton, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.PreviewMeshCollectionFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CurrentSkeleton = 0;
	}
}