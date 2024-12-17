using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DamageEvent")]
	public partial class FDamageEvent : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.DamageEvent");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDamageEvent() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDamageEvent() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDamageEvent A, FDamageEvent B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDamageEvent A, FDamageEvent B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDamageEvent;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<UDamageType> DamageTypeClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DamageTypeClass, __ReturnBuffer);

					return *(TSubclassOf<UDamageType>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DamageTypeClass, __InBuffer);
				}
			}
		}

		private static uint __DamageTypeClass = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}