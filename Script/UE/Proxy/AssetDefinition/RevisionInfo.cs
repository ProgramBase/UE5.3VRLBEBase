using Script.CoreUObject;
using Script.Library;

namespace Script.AssetDefinition
{
	[PathName("/Script/AssetDefinition.RevisionInfo")]
	public partial class FRevisionInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AssetDefinition.RevisionInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRevisionInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRevisionInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRevisionInfo A, FRevisionInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRevisionInfo A, FRevisionInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRevisionInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Revision
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Revision, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Revision, __InBuffer);
				}
			}
		}

		public int Changelist
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Changelist, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Changelist, __InBuffer);
				}
			}
		}

		public FDateTime Date
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Date, __ReturnBuffer);

					return *(FDateTime*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Date, __InBuffer);
				}
			}
		}

		private static uint __Revision = 0;

		private static uint __Changelist = 0;

		private static uint __Date = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}