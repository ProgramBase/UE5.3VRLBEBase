using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PlatformInterfaceBase")]
	public partial class UPlatformInterfaceBase : UObject, IStaticClass
	{
		public TArray<FDelegateArray> AllDelegates
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AllDelegates, __ReturnBuffer);

					return *(TArray<FDelegateArray>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AllDelegates, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PlatformInterfaceBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AllDelegates = 0;
	}
}