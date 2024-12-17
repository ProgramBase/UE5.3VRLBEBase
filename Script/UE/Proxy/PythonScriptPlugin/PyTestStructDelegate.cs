using Script.CoreUObject;
using Script.PythonScriptPlugin.PyTestStructDelegate;
using Script.Library;

namespace Script.PythonScriptPlugin
{
	[PathName("/Script/PythonScriptPlugin.PyTestStructDelegate")]
	public partial class UPyTestStructDelegate : UObject, IStaticClass
	{
		public FOnNameCollisionDelegate OnNameCollisionTestDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnNameCollisionTestDelegate, __ReturnBuffer);

					return *(FOnNameCollisionDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnNameCollisionTestDelegate, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PythonScriptPlugin.PyTestStructDelegate");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __OnNameCollisionTestDelegate = 0;
	}
}