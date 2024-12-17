using Script.CoreUObject;
using Script.Library;

namespace Script.EngineSettings
{
	[PathName("/Script/EngineSettings.AutoCompleteCommand")]
	public partial class FAutoCompleteCommand : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EngineSettings.AutoCompleteCommand");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAutoCompleteCommand() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAutoCompleteCommand() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAutoCompleteCommand A, FAutoCompleteCommand B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAutoCompleteCommand A, FAutoCompleteCommand B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAutoCompleteCommand;

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

		public FString Desc
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Desc, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Desc, __InBuffer);
				}
			}
		}

		private static uint __Command = 0;

		private static uint __Desc = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}