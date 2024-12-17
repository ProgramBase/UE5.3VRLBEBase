using Script.CoreUObject;
using Script.Library;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.LODManagerLODInfo")]
	public partial class FLODManagerLODInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MeshLODToolset.LODManagerLODInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLODManagerLODInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLODManagerLODInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLODManagerLODInfo A, FLODManagerLODInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLODManagerLODInfo A, FLODManagerLODInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLODManagerLODInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int VertexCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VertexCount, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VertexCount, __InBuffer);
				}
			}
		}

		public int TriangleCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TriangleCount, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TriangleCount, __InBuffer);
				}
			}
		}

		private static uint __VertexCount = 0;

		private static uint __TriangleCount = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}