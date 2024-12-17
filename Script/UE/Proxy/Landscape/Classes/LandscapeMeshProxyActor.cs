using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.LandscapeMeshProxyActor")]
	public partial class ALandscapeMeshProxyActor : AActor, IStaticClass
	{
		public ULandscapeMeshProxyComponent LandscapeMeshProxyComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LandscapeMeshProxyComponent, __ReturnBuffer);

					return *(ULandscapeMeshProxyComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LandscapeMeshProxyComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Landscape.LandscapeMeshProxyActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __LandscapeMeshProxyComponent = 0;
	}
}