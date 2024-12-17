using Script.CoreUObject;
using Script.Library;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.GenerateStaticMeshLODProcess_NormalsSettings")]
	public partial class FGenerateStaticMeshLODProcess_NormalsSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MeshLODToolset.GenerateStaticMeshLODProcess_NormalsSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGenerateStaticMeshLODProcess_NormalsSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGenerateStaticMeshLODProcess_NormalsSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGenerateStaticMeshLODProcess_NormalsSettings A, FGenerateStaticMeshLODProcess_NormalsSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGenerateStaticMeshLODProcess_NormalsSettings A, FGenerateStaticMeshLODProcess_NormalsSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGenerateStaticMeshLODProcess_NormalsSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EGenerateStaticMeshLODProcess_NormalsMethod Method
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Method, __ReturnBuffer);

					return *(EGenerateStaticMeshLODProcess_NormalsMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Method, __InBuffer);
				}
			}
		}

		public float Angle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Angle, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Angle, __InBuffer);
				}
			}
		}

		private static uint __Method = 0;

		private static uint __Angle = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}