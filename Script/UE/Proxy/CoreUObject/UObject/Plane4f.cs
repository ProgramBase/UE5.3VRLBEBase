using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.Plane4f")]
	public partial class FPlane4f : FVector3f, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.Plane4f");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPlane4f()
		{
		}

		public static bool operator ==(FPlane4f A, FPlane4f B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPlane4f A, FPlane4f B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPlane4f;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float W
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __W, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __W, __InBuffer);
				}
			}
		}

		private static uint __W = 0;

	}
}