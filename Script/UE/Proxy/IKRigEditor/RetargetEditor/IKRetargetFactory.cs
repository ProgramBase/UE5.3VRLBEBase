using Script.CoreUObject;
using Script.UnrealEd;
using Script.IKRig;
using Script.Library;

namespace Script.IKRigEditor
{
	[PathName("/Script/IKRigEditor.IKRetargetFactory")]
	public partial class UIKRetargetFactory : UFactory, IStaticClass
	{
		public TWeakObjectPtr<UIKRigDefinition> SourceIKRig
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceIKRig, __ReturnBuffer);

					return *(TWeakObjectPtr<UIKRigDefinition>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceIKRig, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IKRigEditor.IKRetargetFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SourceIKRig = 0;
	}
}