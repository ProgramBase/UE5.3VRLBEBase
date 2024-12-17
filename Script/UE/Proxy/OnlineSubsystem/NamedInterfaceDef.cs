using Script.CoreUObject;
using Script.Library;

namespace Script.OnlineSubsystem
{
	[PathName("/Script/OnlineSubsystem.NamedInterfaceDef")]
	public partial class FNamedInterfaceDef : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/OnlineSubsystem.NamedInterfaceDef");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNamedInterfaceDef() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNamedInterfaceDef() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNamedInterfaceDef A, FNamedInterfaceDef B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNamedInterfaceDef A, FNamedInterfaceDef B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNamedInterfaceDef;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName InterfaceName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InterfaceName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InterfaceName, __InBuffer);
				}
			}
		}

		public FString InterfaceClassName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InterfaceClassName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InterfaceClassName, __InBuffer);
				}
			}
		}

		private static uint __InterfaceName = 0;

		private static uint __InterfaceClassName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}