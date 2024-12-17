using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlRigPoseProjectSettings")]
	public partial class UControlRigPoseProjectSettings : UObject, IStaticClass
	{
		public TArray<FDirectoryPath> RootSaveDirs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RootSaveDirs, __ReturnBuffer);

					return *(TArray<FDirectoryPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RootSaveDirs, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRig.ControlRigPoseProjectSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __RootSaveDirs = 0;
	}
}