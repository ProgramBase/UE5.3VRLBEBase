using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InstancedStaticMeshInstanceData")]
	public partial class FInstancedStaticMeshInstanceData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.InstancedStaticMeshInstanceData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInstancedStaticMeshInstanceData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInstancedStaticMeshInstanceData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInstancedStaticMeshInstanceData A, FInstancedStaticMeshInstanceData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInstancedStaticMeshInstanceData A, FInstancedStaticMeshInstanceData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInstancedStaticMeshInstanceData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMatrix Transform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Transform, __ReturnBuffer);

					return *(FMatrix*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Transform, __InBuffer);
				}
			}
		}

		private static uint __Transform = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}