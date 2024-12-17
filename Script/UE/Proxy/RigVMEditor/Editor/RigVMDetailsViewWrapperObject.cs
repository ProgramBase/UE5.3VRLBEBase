using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMEditor
{
	[PathName("/Script/RigVMEditor.RigVMDetailsViewWrapperObject")]
	public partial class URigVMDetailsViewWrapperObject : UObject, IStaticClass
	{
		public TWeakObjectPtr<UObject> SubjectPtr
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SubjectPtr, __ReturnBuffer);

					return *(TWeakObjectPtr<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SubjectPtr, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMEditor.RigVMDetailsViewWrapperObject");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SubjectPtr = 0;
	}
}