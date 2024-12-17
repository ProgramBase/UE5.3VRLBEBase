using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDynamicMeshSection")]
	public partial class FNiagaraDynamicMeshSection : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraDynamicMeshSection");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraDynamicMeshSection() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraDynamicMeshSection() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraDynamicMeshSection A, FNiagaraDynamicMeshSection B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraDynamicMeshSection A, FNiagaraDynamicMeshSection B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraDynamicMeshSection;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int NumTriangles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumTriangles, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumTriangles, __InBuffer);
				}
			}
		}

		public int MaterialIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaterialIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaterialIndex, __InBuffer);
				}
			}
		}

		private static uint __NumTriangles = 0;

		private static uint __MaterialIndex = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}