using Script.CoreUObject;
using Script.Library;

namespace Script.EngineMessages
{
	[PathName("/Script/EngineMessages.EngineServiceExecuteCommand")]
	public partial class FEngineServiceExecuteCommand : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EngineMessages.EngineServiceExecuteCommand");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEngineServiceExecuteCommand() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEngineServiceExecuteCommand() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEngineServiceExecuteCommand A, FEngineServiceExecuteCommand B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEngineServiceExecuteCommand A, FEngineServiceExecuteCommand B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEngineServiceExecuteCommand;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Command
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Command, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Command, __InBuffer);
				}
			}
		}

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

		private static uint __Command = 0;

		private static uint __UserName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}