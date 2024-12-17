using Script.CoreUObject;
using Script.Library;

namespace Script.IKRig
{
	[PathName("/Script/IKRig.IKRetargetProcessor")]
	public partial class UIKRetargetProcessor : UObject, IStaticClass
	{
		public UIKRigProcessor IKRigProcessor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __IKRigProcessor, __ReturnBuffer);

					return *(UIKRigProcessor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __IKRigProcessor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IKRig.IKRetargetProcessor");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __IKRigProcessor = 0;
	}
}