using Script.CoreUObject;
using Script.Library;

namespace Script.EngineSettings
{
	[PathName("/Script/EngineSettings.GameModeName")]
	public partial class FGameModeName : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EngineSettings.GameModeName");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGameModeName() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGameModeName() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGameModeName A, FGameModeName B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGameModeName A, FGameModeName B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGameModeName;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Name
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Name, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Name, __InBuffer);
				}
			}
		}

		public FSoftClassPath GameMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GameMode, __ReturnBuffer);

					return *(FSoftClassPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GameMode, __InBuffer);
				}
			}
		}

		private static uint __Name = 0;

		private static uint __GameMode = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}