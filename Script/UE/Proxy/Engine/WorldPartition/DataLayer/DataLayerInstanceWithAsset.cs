using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DataLayerInstanceWithAsset")]
	public partial class UDataLayerInstanceWithAsset : UDataLayerInstance, IStaticClass
	{
		public UDataLayerAsset DataLayerAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayerAsset, __ReturnBuffer);

					return *(UDataLayerAsset*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayerAsset, __InBuffer);
				}
			}
		}

		public bool bIsIncludedInActorFilterDefault
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsIncludedInActorFilterDefault, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsIncludedInActorFilterDefault, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DataLayerInstanceWithAsset");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DataLayerAsset = 0;

		private static uint __bIsIncludedInActorFilterDefault = 0;
	}
}