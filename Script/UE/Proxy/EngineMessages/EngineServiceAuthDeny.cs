using Script.CoreUObject;
using Script.Library;

namespace Script.EngineMessages
{
	[PathName("/Script/EngineMessages.EngineServiceAuthDeny")]
	public partial class FEngineServiceAuthDeny : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EngineMessages.EngineServiceAuthDeny");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEngineServiceAuthDeny() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEngineServiceAuthDeny() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEngineServiceAuthDeny A, FEngineServiceAuthDeny B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEngineServiceAuthDeny A, FEngineServiceAuthDeny B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEngineServiceAuthDeny;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString UserName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UserName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UserName, __InBuffer);
				}
			}
		}

		public FString UserToDeny
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UserToDeny, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UserToDeny, __InBuffer);
				}
			}
		}

		private static uint __UserName = 0;

		private static uint __UserToDeny = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}