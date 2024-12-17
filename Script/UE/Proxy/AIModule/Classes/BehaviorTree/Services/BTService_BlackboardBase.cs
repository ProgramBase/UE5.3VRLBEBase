using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BTService_BlackboardBase")]
	public partial class UBTService_BlackboardBase : UBTService, IStaticClass
	{
		public FBlackboardKeySelector BlackboardKey
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BlackboardKey, __ReturnBuffer);

					return *(FBlackboardKeySelector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BlackboardKey, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BTService_BlackboardBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __BlackboardKey = 0;
	}
}