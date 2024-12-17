using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.MeshTriCoordinate")]
	public partial class FMeshTriCoordinate : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.MeshTriCoordinate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMeshTriCoordinate() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMeshTriCoordinate() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMeshTriCoordinate A, FMeshTriCoordinate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMeshTriCoordinate A, FMeshTriCoordinate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMeshTriCoordinate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int Tri
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Tri, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Tri, __InBuffer);
				}
			}
		}

		public FVector3f BaryCoord
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BaryCoord, __ReturnBuffer);

					return *(FVector3f*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BaryCoord, __InBuffer);
				}
			}
		}

		private static uint __Tri = 0;

		private static uint __BaryCoord = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}