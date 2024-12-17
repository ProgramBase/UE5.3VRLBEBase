using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.CableComponent
{
	[PathName("/Script/CableComponent.CableActor")]
	public partial class ACableActor : AActor, IStaticClass
	{
		public UCableComponent CableComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CableComponent, __ReturnBuffer);

					return *(UCableComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CableComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CableComponent.CableActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CableComponent = 0;
	}
}