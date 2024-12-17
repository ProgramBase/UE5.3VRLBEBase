using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BakedCustomAttributePerBoneData")]
	public partial class FBakedCustomAttributePerBoneData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BakedCustomAttributePerBoneData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBakedCustomAttributePerBoneData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBakedCustomAttributePerBoneData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBakedCustomAttributePerBoneData A, FBakedCustomAttributePerBoneData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBakedCustomAttributePerBoneData A, FBakedCustomAttributePerBoneData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBakedCustomAttributePerBoneData;

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

		public TArray<FBakedStringCustomAttribute> StringAttributes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StringAttributes, __ReturnBuffer);

					return *(TArray<FBakedStringCustomAttribute>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StringAttributes, __InBuffer);
				}
			}
		}

		public TArray<FBakedIntegerCustomAttribute> IntAttributes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IntAttributes, __ReturnBuffer);

					return *(TArray<FBakedIntegerCustomAttribute>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IntAttributes, __InBuffer);
				}
			}
		}

		public TArray<FBakedFloatCustomAttribute> FloatAttributes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FloatAttributes, __ReturnBuffer);

					return *(TArray<FBakedFloatCustomAttribute>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FloatAttributes, __InBuffer);
				}
			}
		}

		private static uint __BoneTreeIndex = 0;

		private static uint __StringAttributes = 0;

		private static uint __IntAttributes = 0;

		private static uint __FloatAttributes = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}