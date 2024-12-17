using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.Plane4d")]
	public partial class FPlane4d : FVector3d, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.Plane4d");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPlane4d()
		{
		}

		public static bool operator ==(FPlane4d A, FPlane4d B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPlane4d A, FPlane4d B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPlane4d;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public double W
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __W, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __W, __InBuffer);
				}
			}
		}

		private static uint __W = 0;

	}
}