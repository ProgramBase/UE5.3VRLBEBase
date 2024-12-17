using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CustomAttributePerBoneData")]
	public partial class FCustomAttributePerBoneData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CustomAttributePerBoneData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCustomAttributePerBoneData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCustomAttributePerBoneData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCustomAttributePerBoneData A, FCustomAttributePerBoneData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCustomAttributePerBoneData A, FCustomAttributePerBoneData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCustomAttributePerBoneData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int BoneTreeIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneTreeIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneTreeIndex, __InBuffer);
				}
			}
		}

		public TArray<FCustomAttribute> Attributes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Attributes, __ReturnBuffer);

					return *(TArray<FCustomAttribute>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Attributes, __InBuffer);
				}
			}
		}

		private static uint __BoneTreeIndex = 0;

		private static uint __Attributes = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}