using Script.CoreUObject;
using Script.Library;

namespace Script.OnlineSubsystem
{
	[PathName("/Script/OnlineSubsystem.NamedInterface")]
	public partial class FNamedInterface : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/OnlineSubsystem.NamedInterface");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNamedInterface() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNamedInterface() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNamedInterface A, FNamedInterface B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNamedInterface A, FNamedInterface B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNamedInterface;

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

		public UObject InterfaceObject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InterfaceObject, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InterfaceObject, __InBuffer);
				}
			}
		}

		private static uint __InterfaceName = 0;

		private static uint __InterfaceObject = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}