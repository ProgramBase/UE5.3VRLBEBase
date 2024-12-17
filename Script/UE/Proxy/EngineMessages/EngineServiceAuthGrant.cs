using Script.CoreUObject;
using Script.Library;

namespace Script.EngineMessages
{
	[PathName("/Script/EngineMessages.EngineServiceAuthGrant")]
	public partial class FEngineServiceAuthGrant : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EngineMessages.EngineServiceAuthGrant");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEngineServiceAuthGrant() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEngineServiceAuthGrant() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEngineServiceAuthGrant A, FEngineServiceAuthGrant B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEngineServiceAuthGrant A, FEngineServiceAuthGrant B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEngineServiceAuthGrant;

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

		public FString UserToGrant
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UserToGrant, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UserToGrant, __InBuffer);
				}
			}
		}

		private static uint __UserName = 0;

		private static uint __UserToGrant = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}