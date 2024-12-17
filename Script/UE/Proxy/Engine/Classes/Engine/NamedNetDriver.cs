using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NamedNetDriver")]
	public partial class FNamedNetDriver : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.NamedNetDriver");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNamedNetDriver() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNamedNetDriver() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNamedNetDriver A, FNamedNetDriver B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNamedNetDriver A, FNamedNetDriver B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNamedNetDriver;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UNetDriver NetDriver
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NetDriver, __ReturnBuffer);

					return *(UNetDriver*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NetDriver, __InBuffer);
				}
			}
		}

		private static uint __NetDriver = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}