using Script.CoreUObject;
using Script.Library;

namespace Script.DeveloperToolSettings
{
	[PathName("/Script/DeveloperToolSettings.PakOrderFileSpec")]
	public partial class FPakOrderFileSpec : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DeveloperToolSettings.PakOrderFileSpec");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPakOrderFileSpec() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPakOrderFileSpec() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPakOrderFileSpec A, FPakOrderFileSpec B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPakOrderFileSpec A, FPakOrderFileSpec B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPakOrderFileSpec;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Pattern
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Pattern, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Pattern, __InBuffer);
				}
			}
		}

		public int Priority
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Priority, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Priority, __InBuffer);
				}
			}
		}

		private static uint __Pattern = 0;

		private static uint __Priority = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}