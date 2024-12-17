using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PointDamageEvent")]
	public partial class FPointDamageEvent : FDamageEvent, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PointDamageEvent");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPointDamageEvent()
		{
		}

		public static bool operator ==(FPointDamageEvent A, FPointDamageEvent B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPointDamageEvent A, FPointDamageEvent B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPointDamageEvent;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Damage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Damage, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Damage, __InBuffer);
				}
			}
		}

		public FVector_NetQuantizeNormal ShotDirection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ShotDirection, __ReturnBuffer);

					return *(FVector_NetQuantizeNormal*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ShotDirection, __InBuffer);
				}
			}
		}

		public FHitResult HitInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HitInfo, __ReturnBuffer);

					return *(FHitResult*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HitInfo, __InBuffer);
				}
			}
		}

		private static uint __Damage = 0;

		private static uint __ShotDirection = 0;

		private static uint __HitInfo = 0;

	}
}