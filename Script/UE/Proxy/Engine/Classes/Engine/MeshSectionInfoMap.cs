using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MeshSectionInfoMap")]
	public partial class FMeshSectionInfoMap : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.MeshSectionInfoMap");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMeshSectionInfoMap() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMeshSectionInfoMap() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMeshSectionInfoMap A, FMeshSectionInfoMap B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMeshSectionInfoMap A, FMeshSectionInfoMap B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMeshSectionInfoMap;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<uint, FMeshSectionInfo> Map
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Map, __ReturnBuffer);

					return *(TMap<uint, FMeshSectionInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Map, __InBuffer);
				}
			}
		}

		private static uint __Map = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}