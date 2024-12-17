using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/NiagaraCollisionEventPayload_SWC.NiagaraCollisionEventPayload_SWC")]
	public partial class NiagaraCollisionEventPayload_SWC : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Engine/NiagaraCollisionEventPayload_SWC.NiagaraCollisionEventPayload_SWC");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public NiagaraCollisionEventPayload_SWC() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~NiagaraCollisionEventPayload_SWC() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(NiagaraCollisionEventPayload_SWC A, NiagaraCollisionEventPayload_SWC B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(NiagaraCollisionEventPayload_SWC A, NiagaraCollisionEventPayload_SWC B) => !(A == B);

		public override bool Equals(object Other) => this == Other as NiagaraCollisionEventPayload_SWC;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector3f CollisionPos
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CollisionPos, __ReturnBuffer);

					return *(FVector3f*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CollisionPos, __InBuffer);
				}
			}
		}

		public FVector3f CollisionNormal
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CollisionNormal, __ReturnBuffer);

					return *(FVector3f*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CollisionNormal, __InBuffer);
				}
			}
		}

		public FVector3f CollisionVelocity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CollisionVelocity, __ReturnBuffer);

					return *(FVector3f*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CollisionVelocity, __InBuffer);
				}
			}
		}

		public int ParticleIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParticleIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParticleIndex, __InBuffer);
				}
			}
		}

		public int PhysicalMaterialIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PhysicalMaterialIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PhysicalMaterialIndex, __InBuffer);
				}
			}
		}

		private static uint __CollisionPos = 0;

		private static uint __CollisionNormal = 0;

		private static uint __CollisionVelocity = 0;

		private static uint __ParticleIndex = 0;

		private static uint __PhysicalMaterialIndex = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}