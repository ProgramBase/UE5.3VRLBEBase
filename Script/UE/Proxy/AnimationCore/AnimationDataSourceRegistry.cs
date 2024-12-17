using Script.CoreUObject;
using Script.Library;

namespace Script.AnimationCore
{
	[PathName("/Script/AnimationCore.AnimationDataSourceRegistry")]
	public partial class UAnimationDataSourceRegistry : UObject, IStaticClass
	{
		public TMap<FName, TWeakObjectPtr<UObject>> DataSources
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataSources, __ReturnBuffer);

					return *(TMap<FName, TWeakObjectPtr<UObject>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataSources, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationCore.AnimationDataSourceRegistry");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DataSources = 0;
	}
}