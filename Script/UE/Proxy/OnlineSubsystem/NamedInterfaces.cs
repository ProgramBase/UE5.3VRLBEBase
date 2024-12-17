using Script.CoreUObject;
using Script.Library;

namespace Script.OnlineSubsystem
{
	[PathName("/Script/OnlineSubsystem.NamedInterfaces")]
	public partial class UNamedInterfaces : UObject, IStaticClass
	{
		public TArray<FNamedInterface> NamedInterfaces
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NamedInterfaces, __ReturnBuffer);

					return *(TArray<FNamedInterface>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NamedInterfaces, __InBuffer);
				}
			}
		}

		public TArray<FNamedInterfaceDef> NamedInterfaceDefs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NamedInterfaceDefs, __ReturnBuffer);

					return *(TArray<FNamedInterfaceDef>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NamedInterfaceDefs, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OnlineSubsystem.NamedInterfaces");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __NamedInterfaces = 0;

		private static uint __NamedInterfaceDefs = 0;
	}
}