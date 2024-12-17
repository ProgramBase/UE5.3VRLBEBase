using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.MetasoundFrontendGraphClassPresetOptions")]
	public partial class FMetasoundFrontendGraphClassPresetOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundFrontend.MetasoundFrontendGraphClassPresetOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundFrontendGraphClassPresetOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetasoundFrontendGraphClassPresetOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetasoundFrontendGraphClassPresetOptions A, FMetasoundFrontendGraphClassPresetOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundFrontendGraphClassPresetOptions A, FMetasoundFrontendGraphClassPresetOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundFrontendGraphClassPresetOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bIsPreset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsPreset, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsPreset, __InBuffer);
				}
			}
		}

		public TSet<FName> InputsInheritingDefault
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InputsInheritingDefault, __ReturnBuffer);

					return *(TSet<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InputsInheritingDefault, __InBuffer);
				}
			}
		}

		private static uint __bIsPreset = 0;

		private static uint __InputsInheritingDefault = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}