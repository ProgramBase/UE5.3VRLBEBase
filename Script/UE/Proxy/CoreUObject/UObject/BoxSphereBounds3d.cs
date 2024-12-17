using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.BoxSphereBounds3d")]
	public partial class FBoxSphereBounds3d : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.BoxSphereBounds3d");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBoxSphereBounds3d() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBoxSphereBounds3d() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBoxSphereBounds3d A, FBoxSphereBounds3d B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBoxSphereBounds3d A, FBoxSphereBounds3d B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBoxSphereBounds3d;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector3d Origin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Origin, __ReturnBuffer);

					return *(FVector3d*)__ReturnBuffer;
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

		public FVector3d BoxExtent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoxExtent, __ReturnBuffer);

					return *(FVector3d*)__ReturnBuffer;
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

		public double SphereRadius
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SphereRadius, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

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