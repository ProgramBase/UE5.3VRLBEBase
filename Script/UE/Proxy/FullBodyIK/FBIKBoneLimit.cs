using Script.CoreUObject;
using Script.Library;

namespace Script.FullBodyIK
{
	[PathName("/Script/FullBodyIK.FBIKBoneLimit")]
	public partial class FFBIKBoneLimit : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/FullBodyIK.FBIKBoneLimit");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFBIKBoneLimit() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFBIKBoneLimit() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFBIKBoneLimit A, FFBIKBoneLimit B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFBIKBoneLimit A, FFBIKBoneLimit B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFBIKBoneLimit;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EFBIKBoneLimitType LimitType_X
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LimitType_X, __ReturnBuffer);

					return *(EFBIKBoneLimitType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LimitType_X, __InBuffer);
				}
			}
		}

		public EFBIKBoneLimitType LimitType_Y
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LimitType_Y, __ReturnBuffer);

					return *(EFBIKBoneLimitType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LimitType_Y, __InBuffer);
				}
			}
		}

		public EFBIKBoneLimitType LimitType_Z
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LimitType_Z, __ReturnBuffer);

					return *(EFBIKBoneLimitType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LimitType_Z, __InBuffer);
				}
			}
		}

		public FVector Limit
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Limit, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Limit, __InBuffer);
				}
			}
		}

		private static uint __LimitType_X = 0;

		private static uint __LimitType_Y = 0;

		private static uint __LimitType_Z = 0;

		private static uint __Limit = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}