using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.MetasoundFrontendClassInterface")]
	public partial class FMetasoundFrontendClassInterface : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundFrontend.MetasoundFrontendClassInterface");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundFrontendClassInterface() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetasoundFrontendClassInterface() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetasoundFrontendClassInterface A, FMetasoundFrontendClassInterface B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundFrontendClassInterface A, FMetasoundFrontendClassInterface B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundFrontendClassInterface;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMetasoundFrontendInterfaceStyle InputStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InputStyle, __ReturnBuffer);

					return *(FMetasoundFrontendInterfaceStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InputStyle, __InBuffer);
				}
			}
		}

		public FMetasoundFrontendInterfaceStyle OutputStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OutputStyle, __ReturnBuffer);

					return *(FMetasoundFrontendInterfaceStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OutputStyle, __InBuffer);
				}
			}
		}

		public TArray<FMetasoundFrontendClassInput> Inputs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Inputs, __ReturnBuffer);

					return *(TArray<FMetasoundFrontendClassInput>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Inputs, __InBuffer);
				}
			}
		}

		public TArray<FMetasoundFrontendClassOutput> Outputs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Outputs, __ReturnBuffer);

					return *(TArray<FMetasoundFrontendClassOutput>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Outputs, __InBuffer);
				}
			}
		}

		public TArray<FMetasoundFrontendClassEnvironmentVariable> Environment
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Environment, __ReturnBuffer);

					return *(TArray<FMetasoundFrontendClassEnvironmentVariable>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Environment, __InBuffer);
				}
			}
		}

		public FGuid ChangeID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ChangeID, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ChangeID, __InBuffer);
				}
			}
		}

		private static uint __InputStyle = 0;

		private static uint __OutputStyle = 0;

		private static uint __Inputs = 0;

		private static uint __Outputs = 0;

		private static uint __Environment = 0;

		private static uint __ChangeID = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}