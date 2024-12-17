using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.Plane")]
	public partial class FPlane : FVector, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.Plane");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPlane()
		{
		}

		public static bool operator ==(FPlane A, FPlane B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPlane A, FPlane B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPlane;

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