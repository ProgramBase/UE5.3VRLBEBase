using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.GenerateStaticMeshLOD_MaterialConfig")]
	public partial class FGenerateStaticMeshLOD_MaterialConfig : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MeshLODToolset.GenerateStaticMeshLOD_MaterialConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGenerateStaticMeshLOD_MaterialConfig() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGenerateStaticMeshLOD_MaterialConfig() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGenerateStaticMeshLOD_MaterialConfig A, FGenerateStaticMeshLOD_MaterialConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGenerateStaticMeshLOD_MaterialConfig A, FGenerateStaticMeshLOD_MaterialConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGenerateStaticMeshLOD_MaterialConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMaterialInterface Material
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Material, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Material, __InBuffer);
				}
			}
		}

		public EGenerateStaticMeshLOD_BakeConstraint Constraint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Constraint, __ReturnBuffer);

					return *(EGenerateStaticMeshLOD_BakeConstraint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Constraint, __InBuffer);
				}
			}
		}

		private static uint __Material = 0;

		private static uint __Constraint = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}