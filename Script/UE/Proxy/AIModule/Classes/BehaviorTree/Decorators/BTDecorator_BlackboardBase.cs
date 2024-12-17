using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BTDecorator_BlackboardBase")]
	public partial class UBTDecorator_BlackboardBase : UBTDecorator, IStaticClass
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BTDecorator_BlackboardBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __BlackboardKey = 0;
	}
}