using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ContentBundleUnsavedActorMonitor")]
	public partial class UContentBundleUnsavedActorMonitor : UObject, IStaticClass
	{
		public TArray<TWeakObjectPtr<AActor>> UnsavedActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UnsavedActors, __ReturnBuffer);

					return *(TArray<TWeakObjectPtr<AActor>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UnsavedActors, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ContentBundleUnsavedActorMonitor");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __UnsavedActors = 0;
	}
}