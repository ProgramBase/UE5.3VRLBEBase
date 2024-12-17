using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SkelMeshSkinWeightInfo")]
	public partial class FSkelMeshSkinWeightInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SkelMeshSkinWeightInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSkelMeshSkinWeightInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSkelMeshSkinWeightInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSkelMeshSkinWeightInfo A, FSkelMeshSkinWeightInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSkelMeshSkinWeightInfo A, FSkelMeshSkinWeightInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSkelMeshSkinWeightInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int Bones
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Bones, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Bones, __InBuffer);
				}
			}
		}

		public byte Weights
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Weights, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Weights, __InBuffer);
				}
			}
		}

		private static uint __Bones = 0;

		private static uint __Weights = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}