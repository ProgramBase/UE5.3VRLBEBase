using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.PlatformUserId")]
	public partial class FPlatformUserId : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.PlatformUserId");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPlatformUserId() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPlatformUserId() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPlatformUserId A, FPlatformUserId B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPlatformUserId A, FPlatformUserId B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPlatformUserId;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int InternalId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InternalId, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InternalId, __InBuffer);
				}
			}
		}

		private static uint __InternalId = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}