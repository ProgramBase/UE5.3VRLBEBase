using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.GridPathFollowingComponent")]
	public partial class UGridPathFollowingComponent : UPathFollowingComponent, IStaticClass
	{
		public UNavLocalGridManager GridManager
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GridManager, __ReturnBuffer);

					return *(UNavLocalGridManager*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GridManager, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.GridPathFollowingComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __GridManager = 0;
	}
}