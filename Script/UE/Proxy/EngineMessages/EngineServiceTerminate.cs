using Script.CoreUObject;
using Script.Library;

namespace Script.EngineMessages
{
	[PathName("/Script/EngineMessages.EngineServiceTerminate")]
	public partial class FEngineServiceTerminate : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EngineMessages.EngineServiceTerminate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEngineServiceTerminate() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEngineServiceTerminate() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEngineServiceTerminate A, FEngineServiceTerminate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEngineServiceTerminate A, FEngineServiceTerminate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEngineServiceTerminate;

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

		private static uint __UserName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}