using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.BoxSphereBounds3f")]
	public partial class FBoxSphereBounds3f : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.BoxSphereBounds3f");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBoxSphereBounds3f() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBoxSphereBounds3f() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBoxSphereBounds3f A, FBoxSphereBounds3f B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBoxSphereBounds3f A, FBoxSphereBounds3f B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBoxSphereBounds3f;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector3f Origin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Origin, __ReturnBuffer);

					return *(FVector3f*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Origin, __InBuffer);
				}
			}
		}

		public FVector3f BoxExtent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoxExtent, __ReturnBuffer);

					return *(FVector3f*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoxExtent, __InBuffer);
				}
			}
		}

		public float SphereRadius
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SphereRadius, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SphereRadius, __InBuffer);
				}
			}
		}

		private static uint __Origin = 0;

		private static uint __BoxExtent = 0;

		private static uint __SphereRadius = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}