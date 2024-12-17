using Script.CoreUObject;
using Script.Library;
using Script.MetasoundFrontend;

namespace Script.MetasoundEngine
{
	[PathName("/Script/MetasoundEngine.MetaSoundBuilderOptions")]
	public partial class FMetaSoundBuilderOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEngine.MetaSoundBuilderOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetaSoundBuilderOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetaSoundBuilderOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetaSoundBuilderOptions A, FMetaSoundBuilderOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetaSoundBuilderOptions A, FMetaSoundBuilderOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetaSoundBuilderOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName Name
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Name, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
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

		public bool bForceUniqueClassName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bForceUniqueClassName, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bForceUniqueClassName, __InBuffer);
				}
			}
		}

		public bool bAddToRegistry
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAddToRegistry, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAddToRegistry, __InBuffer);
				}
			}
		}

		public TScriptInterface<IMetaSoundDocumentInterface> ExistingMetaSound
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExistingMetaSound, __ReturnBuffer);

					return *(TScriptInterface<IMetaSoundDocumentInterface>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExistingMetaSound, __InBuffer);
				}
			}
		}

		private static uint __Name = 0;

		private static uint __bForceUniqueClassName = 0;

		private static uint __bAddToRegistry = 0;

		private static uint __ExistingMetaSound = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}